﻿using Newtonsoft.Json;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AngleSharp.Dom;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumAutotest
{
    public enum StepStates
    {
        NotStarted, Passed, Error, IgnoredError, Skipped, Started
    }

    public enum SelectorType
    {
        ID, Class, XPath, Tag, PartLink
    }

    [Serializable]
    internal class TestStep
    {
        public Guid Id { get; set; } // TODO: check need serialization
        public List<TestStep> Substeps { get; set; }

        public string Name { get; set; }
        public StepTypes Type { get; set; }
        public SelectorType SelectorType { get; set; }
        public string Selector { get; set; }
        public float SecondsToWait { get; set; }
        public string Value { get; set; }
        public string Parameter { get; set; }
        public bool IgnoreError { get; set; }
        public bool Enabled { get; set; }
        public bool ScrollTo { get; set; }
        public bool IgnoreParent { get; set; }
        public bool SkipIfElementNotFound { get; set; }

        public bool Expanded { get; set; }


        [JsonIgnore]
        public TestStep Parent { get; set; }
        [JsonIgnore]
        public Autotest ParentAutotest { get; set; }
        [JsonIgnore]
        public IWebElement FoundElement;
        [JsonIgnore]
        public StepStates StepState;
        [JsonIgnore]
        public string Log;
        [JsonIgnore]
        public TestStep PrevStep;

        public TestStep()
        {
            Id = Guid.NewGuid();
            Substeps = new List<TestStep>();
            SelectorType = SelectorType.XPath;
            Selector = "";
            SecondsToWait = 30;
            Value = "";
            Parameter = "";
            Value = "";
            IgnoreError = false;
            Expanded = true;
            Enabled = true;
            Parent = null;
            ScrollTo = true;
            IgnoreParent = false;
            SkipIfElementNotFound = false;
        }

        public override string ToString()
        {
            string str;
            switch (this.Type)
            {
                // NEWSTEP add name-label for step
                case StepTypes.Click:
                case StepTypes.JsClick:
                case StepTypes.AltClick:
                case StepTypes.DoubleClick:
                case StepTypes.MouseMoveToEl:
                    str = $"{Name}";
                    break;
                case StepTypes.Group:
                    str = Name;
                    break;
                case StepTypes.GroupOneOfSubsteps:
                    str = Name;
                    break;
                case StepTypes.EnterText:
                    str = $"{Name} [{Value}]";
                    break;
                case StepTypes.SetAttribute:
                    str = $"{Name} [{Selector}={Value}]";
                    break;
                case StepTypes.ClearValue:
                    str = $"{Name}";
                    break;
                case StepTypes.CheckElement:
                    str = $"{Name} | {SelectorType}={Selector}";
                    break;
                case StepTypes.WaitTime:
                    str = $"{Name} ({SecondsToWait})";
                    break;
                case StepTypes.FindElement:
                    str = $"{Name} | {SelectorType}={Selector} ({SecondsToWait})";
                    break;
                case StepTypes.CheckClassExists:
                    str = $"{Name} [class={Value}]";
                    break;
                case StepTypes.CheckClassNotExists:
                    str = $"{Name} [class={Value}]";
                    break;
                case StepTypes.CheckText:
                    str = $"{Name} [TEXT={Value}]";
                    break;
                case StepTypes.CompareParameters:
                    str = $"{Name} [{Value} = {Parameter}]";
                    break;
                case StepTypes.Open:
                    str = $"{Name} | {Value}";
                    break;
                case StepTypes.RefreshPage:
                    str = $"{Name}";
                    break;
                case StepTypes.CheckAttribute:
                    str = $"{Name} [{Selector}={Value}]";
                    break;
                case StepTypes.ReadAttributeToParameter:
                    str = $"{Name} [{Selector} => {Parameter}]";
                    break;
                case StepTypes.ReadTextToParameter:
                    str = $"{Name} [TEXT => {Parameter}]";
                    break;
                case StepTypes.ReadAddressToParameter:
                    str = $"{Name} [URL => {Parameter}]";
                    break;
                case StepTypes.InputToParameterByUser:
                    str = $"{Name} [USER => {Parameter}]";
                    break;
                case StepTypes.JsEvent:
                    str = $"{Name} [EVENT={Value}]";
                    break;
                case StepTypes.JsCode:
                    str = $"{Name} [{Value}]";
                    break;
                case StepTypes.ScrollTo:
                    str = $"{Name}";
                    break;
                case StepTypes.ScrollByPixels:
                    str = $"{Name} [{Value}px]";
                    break;
                default:
                    str = "!!! " + Name;
                    break;
            }
            if (IgnoreError)
            {
                str += " | IgnoreError";
            }
            if (!Enabled)
            {
                str += " | SKIP";
            }
            return str;
        }

        private void StepWork(IWebDriver driver, Action StateUpdated, bool slowMode, int slowModeTime, bool selectFoundElements, bool waitPageLoad, int staleErrorCount = 0, CancellationToken? cancellationToken = null)
        {
            try
            {
                if (cancellationToken == null)
                {
                    cancellationToken = new CancellationToken();
                }
                bool isParented = false;
                try
                {
                    if (!Enabled || this.StepState == StepStates.Skipped)
                    {
                        this.StepState = StepStates.Skipped;
                        SetParentStatus(this);
                        return;
                    }
                    this.StepState = StepStates.Started;
                    StateUpdated?.Invoke();

                    if (this.Selector == null) { this.Selector = ""; }
                    if (this.Value == null) { this.Value = ""; }

                    bool needToSlow = false;
                    Log = "";
                    switch (Type)
                    {
                        // NEWSTEP add action for new step
                        case StepTypes.Open:
                            var url = ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                            if (driver.Url == url)
                                driver.Navigate().Refresh();
                            else
                                driver.Navigate().GoToUrl(url);
                            if (selectFoundElements)
                            {
                                string js = @"
                                    (function() {
                                        if (document.getElementById('mouse-tracker')) return;

                                        let dot = document.createElement('div');
                                        dot.id = 'mouse-tracker';
                                        dot.style.position = 'fixed';
                                        dot.style.width = '20px';
                                        dot.style.height = '20px';
                                        dot.style.backgroundColor = 'red';
                                        dot.style.borderRadius = '50%';
                                        dot.style.pointerEvents = 'none';
                                        dot.style.zIndex = '999999';
                                        dot.style.opacity = '0.6';
                                        document.body.appendChild(dot);

                                        document.addEventListener('mousemove', function(e) {
                                            dot.style.left = (e.clientX - 10) + 'px';
                                            dot.style.top = (e.clientY - 10) + 'px';
                                        });
                                    })();
                                    ";

                                ((IJavaScriptExecutor)driver).ExecuteScript(js);
                            }
                            break;
                        case StepTypes.RefreshPage:
                            driver.Navigate().Refresh();
                            if (selectFoundElements)
                            {
                                string js = @"
                                    (function() {
                                        if (document.getElementById('mouse-tracker')) return;

                                        let dot = document.createElement('div');
                                        dot.id = 'mouse-tracker';
                                        dot.style.position = 'fixed';
                                        dot.style.width = '20px';
                                        dot.style.height = '20px';
                                        dot.style.backgroundColor = 'red';
                                        dot.style.borderRadius = '50%';
                                        dot.style.pointerEvents = 'none';
                                        dot.style.zIndex = '999999';
                                        dot.style.opacity = '0.6';
                                        document.body.appendChild(dot);

                                        document.addEventListener('mousemove', function(e) {
                                            dot.style.left = (e.clientX - 10) + 'px';
                                            dot.style.top = (e.clientY - 10) + 'px';
                                        });
                                    })();
                                    ";

                                ((IJavaScriptExecutor)driver).ExecuteScript(js);
                            }
                            break;
                        case StepTypes.FindElement:
                            {
                                needToSlow = true;
                                var selector = ValuesFromParameters.ProcessInput(this.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(this.SecondsToWait));
                                IWebElement el = null;
                                if (this.Parent.FoundElement != null && !IgnoreParent)
                                {
                                    isParented = true;
                                    IReadOnlyCollection<IWebElement> tempElementsBySelector = null;
                                    switch (SelectorType)
                                    {
                                        case SelectorType.ID:
                                            tempElementsBySelector = wait.Until(d => this.Parent.FoundElement.FindElements(By.Id(selector)), cancellationToken.Value);
                                            break;
                                        case SelectorType.Class:
                                            tempElementsBySelector = wait.Until(d => this.Parent.FoundElement.FindElements(By.ClassName(selector)), cancellationToken.Value);
                                            break;
                                        case SelectorType.XPath:
                                            tempElementsBySelector = wait.Until(d => this.Parent.FoundElement.FindElements(By.XPath(selector)), cancellationToken.Value);
                                            break;
                                        case SelectorType.Tag:
                                            tempElementsBySelector = wait.Until(d => this.Parent.FoundElement.FindElements(By.TagName(selector)), cancellationToken.Value);
                                            break;
                                        case SelectorType.PartLink:
                                            tempElementsBySelector = wait.Until(d => this.Parent.FoundElement.FindElements(By.PartialLinkText(selector)), cancellationToken.Value);
                                            break;
                                    }
                                    el = tempElementsBySelector.FirstOrDefault(element => IsChildOf(driver, element, this.Parent.FoundElement));
                                    if (el == null)
                                    {
                                        var selectorParent = ValuesFromParameters.ProcessInput(this.Parent.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                        string fullXPath = GetElementXPath(driver, this.Parent.FoundElement);
                                        throw new Exception($"Дочерний элемент {SelectorType}=\"{selector}\" не найден в родителе: {this.Parent.SelectorType}=\"{selectorParent}\"\r\nПолный путь родителя:\r\n{fullXPath}\r\n");
                                    }
                                }
                                else
                                {
                                    switch (SelectorType)
                                    {
                                        case SelectorType.ID:
                                            el = wait.Until(d => driver.FindElement(By.Id(selector)), cancellationToken.Value);
                                            break;
                                        case SelectorType.Class:
                                            el = wait.Until(d => driver.FindElement(By.ClassName(selector)), cancellationToken.Value);
                                            break;
                                        case SelectorType.XPath:
                                            el = wait.Until(d => driver.FindElement(By.XPath(selector)), cancellationToken.Value);
                                            break;
                                        case SelectorType.Tag:
                                            el = wait.Until(d => driver.FindElement(By.TagName(selector)), cancellationToken.Value);
                                            break;
                                        case SelectorType.PartLink:
                                            el = wait.Until(d => driver.FindElement(By.PartialLinkText(selector)), cancellationToken.Value);
                                            break;
                                    }
                                }
                                FoundElement = el;
                                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                                if (ScrollTo)
                                {
                                    js.ExecuteScript("arguments[0].scrollIntoView({block: 'center', inline: 'center'});", el);
                                }
                                if (selectFoundElements)
                                {
                                    js.ExecuteScript("arguments[0].style.border='2px solid red';", el);
                                }
                            }
                            break;
                        case StepTypes.CheckElement:
                            {
                                var selector = ValuesFromParameters.ProcessInput(this.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                IWebElement el = null;
                                if (this.Parent.FoundElement != null && !IgnoreParent)
                                {
                                    isParented = true;
                                    IReadOnlyCollection<IWebElement> tempElementsBySelector = null;
                                    switch (SelectorType)
                                    {
                                        case SelectorType.ID:
                                            tempElementsBySelector = this.Parent.FoundElement.FindElements(By.Id(selector));
                                            break;
                                        case SelectorType.Class:
                                            tempElementsBySelector = this.Parent.FoundElement.FindElements(By.ClassName(selector));
                                            break;
                                        case SelectorType.XPath:
                                            tempElementsBySelector = this.Parent.FoundElement.FindElements(By.XPath(selector));
                                            break;
                                        case SelectorType.Tag:
                                            tempElementsBySelector = this.Parent.FoundElement.FindElements(By.TagName(selector));
                                            break;
                                        case SelectorType.PartLink:
                                            tempElementsBySelector = this.Parent.FoundElement.FindElements(By.PartialLinkText(selector));
                                            break;
                                    }
                                    el = tempElementsBySelector.FirstOrDefault(element => IsChildOf(driver, element, this.Parent.FoundElement));
                                    if (el == null)
                                    {
                                        var selectorParent = ValuesFromParameters.ProcessInput(this.Parent.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                        string fullXPath = GetElementXPath(driver, this.Parent.FoundElement);
                                        throw new Exception($"Дочерний элемент {SelectorType}=\"{selector}\" не найден в родителе: {this.Parent.SelectorType}=\"{selectorParent}\"\r\nПолный путь родителя:\r\n{fullXPath}\r\n");
                                    }
                                }
                                else
                                {
                                    switch (SelectorType)
                                    {
                                        case SelectorType.ID:
                                            el = driver.FindElement(By.Id(selector));
                                            break;
                                        case SelectorType.Class:
                                            el = driver.FindElement(By.ClassName(selector));
                                            break;
                                        case SelectorType.XPath:
                                            el = driver.FindElement(By.XPath(selector));
                                            break;
                                        case SelectorType.Tag:
                                            el = driver.FindElement(By.TagName(selector));
                                            break;
                                        case SelectorType.PartLink:
                                            el = driver.FindElement(By.PartialLinkText(selector));
                                            break;
                                    }
                                }
                                this.FoundElement = el;
                            }
                            break;
                        case StepTypes.EnterText:
                            {
                                isParented = true;
                                needToSlow = true;
                                string value = ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                var el = this.Parent.FoundElement;
                                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                                js.ExecuteScript("arguments[0].value = '';", el);
                                el.SendKeys(value);
                            }
                            break;
                        case StepTypes.SetAttribute:
                            {
                                isParented = true;
                                needToSlow = true;
                                string value = ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                var el = this.Parent.FoundElement;
                                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                                js.ExecuteScript("arguments[0].setAttribute(arguments[1], arguments[2]);", el, this.Selector, value);
                            }
                            break;
                        case StepTypes.ClearValue:
                            {
                                isParented = true;
                                needToSlow = true;
                                string value = ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                var el = this.Parent.FoundElement;
                                el.Clear();
                            }
                            break;
                        case StepTypes.Click:
                            {
                                isParented = true;
                                needToSlow = true;
                                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                                var el = wait.Until(ExpectedConditions.ElementToBeClickable(this.Parent.FoundElement));
                                el.Click();
                            }
                            break;
                        case StepTypes.JsClick:
                            {
                                isParented = true;
                                needToSlow = true;
                                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                                var el = wait.Until(ExpectedConditions.ElementToBeClickable(this.Parent.FoundElement));
                                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", el);
                            }
                            break;
                        case StepTypes.AltClick:
                            {
                                isParented = true;
                                needToSlow = true;
                                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                                var el = wait.Until(ExpectedConditions.ElementToBeClickable(this.Parent.FoundElement));
                                Actions action = new Actions(driver);
                                action.Click(el).Build().Perform();
                            }
                            break;
                        case StepTypes.DoubleClick:
                            {
                                isParented = true;
                                needToSlow = true;
                                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                                var el = wait.Until(ExpectedConditions.ElementToBeClickable(this.Parent.FoundElement));
                                Actions action = new Actions(driver);
                                action.DoubleClick(el).Build().Perform();
                            }
                            break;
                        case StepTypes.MouseMoveToEl:
                            {
                                isParented = true;
                                needToSlow = true;
                                Actions action = new Actions(driver);
                                action.MoveToElement(this.Parent.FoundElement).Build().Perform();
                            }
                            break;
                        case StepTypes.JsEvent:
                            {
                                isParented = true;
                                needToSlow = true;
                                var el = this.Parent.FoundElement;
                                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                                js.ExecuteScript($"arguments[0].dispatchEvent(new Event('{Value}'));", el);
                            }
                            break;
                        case StepTypes.CheckText:
                            {
                                isParented = true;
                                var el = this.Parent.FoundElement;
                                var text = el.Text.Replace("\r", "").Replace("\n", "").Trim();
                                if (!IsMatchMask(text, ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters)))
                                {
                                    throw new Exception($"Ожидалось [{ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters)}], было [{text}]");
                                }
                                Log = $"Значение = [{text}]";
                            }
                            break;
                        case StepTypes.CheckAttribute:
                            {
                                isParented = true;
                                var selector = ValuesFromParameters.ProcessInput(this.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                var el = this.Parent.FoundElement;
                                if (el.GetAttribute(selector) == null)
                                {
                                    throw new Exception($"Атрибут {selector} не найден");
                                }
                                var text = el.GetAttribute(selector).Replace("\r", "").Replace("\n", "").Trim();
                                if (!IsMatchMask(text, ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters)))
                                {
                                    throw new Exception($"Ожидалось [{ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters)}], было [{text}]");
                                }
                                Log = $"Значение = [{text}]";
                            }
                            break;
                        case StepTypes.CheckClassExists:
                            {
                                isParented = true;
                                if (!this.Parent.FoundElement.GetAttribute("class").Contains(ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters)))
                                {
                                    throw new Exception($"Класс [{ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters)}] не найден в элементе");
                                }
                            }
                            break;
                        case StepTypes.CheckClassNotExists:
                            {
                                isParented = true;
                                if (this.Parent.FoundElement.GetAttribute("class").Contains(ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters)))
                                {
                                    throw new Exception($"Класс [{ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters)}] не найден в элементе");
                                }
                            }
                            break;
                        case StepTypes.WaitTime:
                            {
                                Thread.Sleep((int)(this.SecondsToWait * 1000f));
                            }
                            break;
                        case StepTypes.ReadAttributeToParameter:
                            {
                                isParented = true;
                                var el = this.Parent.FoundElement;
                                var selector = ValuesFromParameters.ProcessInput(this.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                var value = el.GetAttribute(selector) ?? "";
                                SetParameter(value, this.Parameter);
                                Log = $"Значение = [{value}]";
                            }
                            break;
                        case StepTypes.ReadTextToParameter:
                            {
                                isParented = true;
                                var el = this.Parent.FoundElement;
                                var value = el.Text;
                                SetParameter(value, this.Parameter);
                                Log = $"Значение = [{value}]";
                            }
                            break;
                        case StepTypes.ReadAddressToParameter:
                            {
                                var value = driver.Url;
                                SetParameter(value, this.Parameter);
                                Log = $"Значение = [{value}]";
                            }
                            break;
                        case StepTypes.CompareParameters:
                            {
                                var value1 = ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                var value2 = ValuesFromParameters.ProcessInput(this.Parameter, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                if (value1 != value2)
                                {
                                    throw new Exception($"Param1 [{value1}] ({value1.GetType()})\r\nParam2 [{value2}] ({value2.GetType()})");
                                }
                                Log = $"[{value1}] = [{value2}]";
                            }
                            break;
                        case StepTypes.InputToParameterByUser:
                            {
                                InputDataForm inputDataForm = new InputDataForm(this.Parameter, this.Name);
                                if (inputDataForm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                                {
                                    throw new Exception($"Не введён параметр");
                                }
                                foreach (var param in ParentAutotest.ParentProject.Parameters)
                                {
                                    if (param.Name == this.Parameter)
                                    {
                                        param.Value = inputDataForm.Result;
                                        ParentAutotest.ParentProject.InvokeParametersUpdated();
                                    }
                                }
                                foreach (var param in ParentAutotest.Parameters)
                                {
                                    if (param.Name == this.Parameter)
                                    {
                                        param.Value = inputDataForm.Result;
                                        ParentAutotest.InvokeParametersUpdated();
                                    }
                                }
                                Log = $"Значение = [{inputDataForm.Result}]";
                            }
                            break;
                        case StepTypes.ScrollTo:
                            {
                                isParented = true;
                                var el = this.Parent.FoundElement; 
                                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                                js.ExecuteScript("arguments[0].scrollIntoView({block: 'center', inline: 'center'});", el);
                                Thread.Sleep(500);
                            }
                            break;
                        case StepTypes.ScrollByPixels:
                            {
                                var value = ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                if (string.IsNullOrEmpty(value))
                                {
                                    value = "0";
                                }
                                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                                js.ExecuteScript($"window.scrollBy(0, {value});");
                                Thread.Sleep(500);
                            }
                            break;
                        case StepTypes.JsCode:
                            {
                                var code = ValuesFromParameters.ProcessInput(this.Value, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                                js.ExecuteScript(code);
                            }
                            break;
                        default:
                            needToSlow = false;
                            break;
                    }
                    if (waitPageLoad)
                    {
                        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(600));
                        wait.Until(d =>
                            ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").ToString() == "complete");
                    }
                    if (this.Substeps.Count == 0)
                    {
                        this.StepState = StepStates.Passed;
                        SetParentStatus(this);
                    }
                    if (needToSlow && slowMode)
                    {
                        Thread.Sleep(slowModeTime);
                    }
                }
                catch (StaleElementReferenceException ex)
                {
                    staleErrorCount++;
                    if (staleErrorCount < 10)
                    {
                        Thread.Sleep(1000);
                        StepWork(driver, StateUpdated, slowMode, slowModeTime, selectFoundElements, waitPageLoad, staleErrorCount);
                    }
                    else
                    {

                        var selector = "-";
                        if (isParented)
                            selector = ValuesFromParameters.ProcessInput(this.Parent.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                        else
                            selector = ValuesFromParameters.ProcessInput(this.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);

                        this.Log = $"Элемент {SelectorType}=\"{selector}\" невалиден по неизвестной причине после 10 секунд ожидания (попробуйте перенайти элемент ещё раз перед вызовом этого действия) \r\n\r\n" + ex.ToString();
                        throw;
                    }
                }
                catch (NoSuchElementException ex)
                {
                    var selector = "-";
                    if (isParented)
                        selector = ValuesFromParameters.ProcessInput(this.Parent.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                    else
                        selector = ValuesFromParameters.ProcessInput(this.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                    this.Log = $"Элемент {SelectorType}=\"{selector}\" не найден\r\n\r\n" + ex.ToString();
                    throw;
                }
                catch (InvalidSelectorException ex)
                {
                    var selector = "-";
                    if (isParented)
                        selector = ValuesFromParameters.ProcessInput(this.Parent.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                    else
                        selector = ValuesFromParameters.ProcessInput(this.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                    this.Log = $"Селектор имеет ошибку {SelectorType}=\"{selector}\"\r\n\r\n" + ex.ToString();
                    throw;
                }
                catch (WebDriverTimeoutException ex)
                {
                    var selector = "-";
                    if (isParented)
                        selector = ValuesFromParameters.ProcessInput(this.Parent.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                    else
                        selector = ValuesFromParameters.ProcessInput(this.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                    this.Log = $"Элемент {SelectorType}=\"{selector}\" не найден за отведённое время\r\n\r\n" + ex.ToString();
                    throw;
                }
                catch (Exception ex)
                {
                    var selector = "-";
                    if (isParented)
                        selector = ValuesFromParameters.ProcessInput(this.Parent.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                    else
                        selector = ValuesFromParameters.ProcessInput(this.Selector, ParentAutotest.ParentProject.Parameters, ParentAutotest.Parameters);
                    this.Log = $"Неизвестная ошибка! {SelectorType}=\"{selector}\"\r\n\r\n" + ex.ToString();
                    throw;
                }
            }
            catch
            {
                bool IsInGroupOneOfSubsteps = GetInGroupOneOfSubstep(this);
                this.StepState = (this.IgnoreError || IsInGroupOneOfSubsteps || SkipIfElementNotFound) ? StepStates.IgnoredError : StepStates.Error;


                SetParentStatus(this);

                if (this.StepState == StepStates.IgnoredError)
                {
                    SetStatusForSubsteps(this, StepStates.Skipped);
                    return;
                }

                if (this.StepState == StepStates.Error)
                {
                    ParentAutotest.ErrorStep = this;
                    throw;
                }
            }
        }

        private void SetStatusForSubsteps(TestStep testStep, StepStates state)
        {
            foreach (TestStep sub in testStep.Substeps)
            {
                sub.StepState = state;
                SetStatusForSubsteps(sub, state);
            }
        }

        private bool GetInGroupOneOfSubstep(TestStep step)
        {
            if (step.Parent != null)
            {
                if (step.Parent.Type == StepTypes.GroupOneOfSubsteps) return true;
                return GetInGroupOneOfSubstep(step.Parent);
            }
            return false;
        }

        private void SetParentStatus(TestStep step)
        {
            if (step.Parent == null) { return; }
            if (step.Parent.Type == StepTypes.GroupOneOfSubsteps)
            {
                if (step.Parent.Substeps.Any(x => x.StepState == StepStates.Passed))
                {
                    step.Parent.StepState = StepStates.Passed;
                }
                else
                {
                    if (step.Parent.Substeps.All(x => x.StepState != StepStates.NotStarted))
                    {
                        step.Parent.StepState = StepStates.Error;
                    }
                }
            }
            else
            {
                if (step.Parent.Substeps.Count == step.Parent.Substeps.Where(x => x.StepState == StepStates.Passed || x.StepState == StepStates.Skipped).Count())
                {
                    step.Parent.StepState = StepStates.Passed;
                }
                if (step.Parent.Substeps.Where(x => x.StepState == StepStates.IgnoredError).Count() > 0)
                {
                    step.Parent.StepState = StepStates.IgnoredError;
                }
                if (step.Parent.Substeps.Where(x => x.StepState == StepStates.Error).Count() > 0)
                {
                    step.Parent.StepState = StepStates.Error;
                }
                if (step.Parent.Substeps.Where(x => x.StepState == StepStates.NotStarted).Count() > 0)
                {
                    step.Parent.StepState = StepStates.Started;
                }
            }
            SetParentStatus(step.Parent);
        }

        private string GetElementXPath(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            return (string)js.ExecuteScript(
                "function getElementXPath(element) {" +
                "   if (element.id !== '') {" +
                "       return 'id(\"' + element.id + '\")';" +
                "   }" +
                "   if (element === document.body) {" +
                "       return element.tagName;" +
                "   }" +
                "   var ix = 0;" +
                "   var siblings = element.parentNode.childNodes;" +
                "   for (var i = 0; i < siblings.length; i++) {" +
                "       var sibling = siblings[i];" +
                "       if (sibling === element) {" +
                "           return getElementXPath(element.parentNode) + '/' + element.tagName + '[' + (ix + 1) + ']';" +
                "       }" +
                "       if (sibling.nodeType === 1 && sibling.tagName === element.tagName) {" +
                "           ix++;" +
                "       }" +
                "   }" +
                "}" +
                "return getElementXPath(arguments[0]);", element);
        }

        private bool IsChildOf(IWebDriver driver, IWebElement child, IWebElement parent)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            return (bool)js.ExecuteScript(
                "var child = arguments[0];" +
                "var parent = arguments[1];" +
                "while (child.parentNode) {" +
                "    if (child.parentNode === parent) {" +
                "        return true;" +
                "    }" +
                "    child = child.parentNode;" +
                "}" +
                "return false;",
                child, parent);
        }

        private void SetParameter(string value, string paramName)
        {
            foreach (var param in ParentAutotest.ParentProject.Parameters)
            {
                if (param.Name == paramName)
                {
                    param.Value = value;
                    ParentAutotest.ParentProject.InvokeParametersUpdated();
                }
            }
            foreach (var param in ParentAutotest.Parameters)
            {
                if (param.Name == paramName)
                {
                    param.Value = value;
                    ParentAutotest.InvokeParametersUpdated();
                }
            }
        }

        private bool IsMatchMask(string input, string pattern)
        {
            pattern = pattern.Replace("\\?", ".").Replace("\\*", ".*");
            string regexPattern = "^" + pattern + "$";
            return Regex.IsMatch(input, regexPattern);
        }

        public void ClearState()
        {
            this.StepState = StepStates.NotStarted;
            this.Log = "";
            foreach (var substep in Substeps)
            {
                substep.ClearState();
            }
        }

        public void MoveUp()
        {
            int index = this.Parent.Substeps.IndexOf(this);
            if (index > 0)
            {
                (this.Parent.Substeps[index], this.Parent.Substeps[index - 1]) = (this.Parent.Substeps[index - 1], this.Parent.Substeps[index]);
            }
        }

        public void MoveDown()
        {
            int index = this.Parent.Substeps.IndexOf(this);
            if (index < this.Parent.Substeps.Count - 1)
            {
                (this.Parent.Substeps[index], this.Parent.Substeps[index + 1]) = (this.Parent.Substeps[index + 1], this.Parent.Substeps[index]);
            }
        }

        public void ResetGuid()
        {
            this.Id = Guid.NewGuid();
            foreach (var substep in Substeps)
            {
                substep.ResetGuid();
            }
        }

        public void AutoModeRun(IWebDriver driver, CancellationToken token, Action StateUpdated, bool slowMode, int slowModeTime, bool selectFoundElements, bool waitPageLoad)
        {
            StepWork(driver, StateUpdated, slowMode, slowModeTime, selectFoundElements, waitPageLoad);

            foreach (var substep in Substeps)
            {
                if (token.IsCancellationRequested)
                    break;
                substep.AutoModeRun(driver, token, StateUpdated, slowMode, slowModeTime, selectFoundElements, waitPageLoad);
            }
        }

        public void StepModeRun(IWebDriver driver, Action StateUpdated, bool selectFoundElements, bool waitPageLoad, CancellationToken cancellationToken)
        {
            StepWork(driver, StateUpdated, false, 0, selectFoundElements, waitPageLoad, 0, cancellationToken);
        }
    }
}
