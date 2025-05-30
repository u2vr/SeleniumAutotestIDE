﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SeleniumAutotest
{
    internal enum StepTypes
    {
        Group, Open, FindElement, Click, CheckText, EnterText, CheckElement, 
        WaitTime, CheckClassExists, DoubleClick, CheckAttribute, ReadAttributeToParameter, 
        ReadTextToParameter, CheckClassNotExists, ReadAddressToParameter, CompareParameters, 
        JsClick, AltClick, JsEvent, SetAttribute, InputToParameterByUser, RefreshPage, ScrollTo, ScrollByPixels, JsCode, GroupOneOfSubsteps, ClearValue,
        MouseMoveToEl
        // Add new to tail
        // Find NEWSTEP for showing where need to add stepTypes (1 in Form1, 2 in TestStep, 2+this here)
    }
    // TODO: Предусмотреть прямое нажатие клавиш клавиатуры (например, для сочетаний)

    internal class StepTypesGroup
    {
        public int ImageIndex { get; set; }
        public string Name { get; set; }
        public List<StepTypes> Types { get; set; }

        public List<StepTypes?> Parents { get; set; } = new List<StepTypes?>();

        public override string ToString()
        {
            return Name;
        }
    }

    internal static class StepType
    {
        public static List<StepTypesGroup> StepTypesGroups { get; set; } = new List<StepTypesGroup>()
        {
            // NEWSTEP add new Group for step or add step to Types  as child of existing group
            new StepTypesGroup(){ 
                ImageIndex = 0,
                Name = "Группа шагов",
                Parents = new List<StepTypes?>(){ StepTypes.Group, null },
                Types = new List<StepTypes>(){ StepTypes.Group, StepTypes.GroupOneOfSubsteps } },
            new StepTypesGroup(){
                ImageIndex = 1,
                Name = "Поиск",                
                Parents = new List<StepTypes?>(){ StepTypes.Group, StepTypes.GroupOneOfSubsteps, StepTypes.FindElement },       
                Types = new List<StepTypes>(){ StepTypes.FindElement } },
            new StepTypesGroup(){
                ImageIndex = 2,
                Name = "Мышь",
                Parents = new List<StepTypes?>(){ StepTypes.FindElement },
                Types = new List<StepTypes>(){ StepTypes.Click, StepTypes.AltClick, StepTypes.JsClick, StepTypes.DoubleClick, StepTypes.MouseMoveToEl } },
            new StepTypesGroup(){
                ImageIndex = 3,
                Name = "Изменить",
                Parents = new List<StepTypes?>(){ StepTypes.FindElement },
                Types = new List<StepTypes>(){ StepTypes.EnterText, StepTypes.SetAttribute, StepTypes.ClearValue } },
            new StepTypesGroup(){
                ImageIndex = 4,
                Name = "Проверить",
                Parents = new List<StepTypes?>(){ StepTypes.FindElement },
                Types = new List<StepTypes>(){ StepTypes.CheckText, StepTypes.CheckClassExists, StepTypes.CheckClassNotExists, StepTypes.CheckAttribute, StepTypes.CompareParameters } },
            new StepTypesGroup(){
                ImageIndex = 6,
                Name = "Сохранить в параметр",
                Parents = new List<StepTypes?>(){ StepTypes.FindElement },
                Types = new List<StepTypes>(){ StepTypes.ReadTextToParameter, StepTypes.ReadAttributeToParameter, StepTypes.ReadAddressToParameter } },
            new StepTypesGroup(){
                ImageIndex = 7,
                Name = "Ждать время",
                Parents = new List<StepTypes?>(){ StepTypes.Group, StepTypes.GroupOneOfSubsteps, StepTypes.FindElement },
                Types = new List<StepTypes>(){ StepTypes.WaitTime } },
            new StepTypesGroup(){
                ImageIndex = 8,
                Name = "Открыть сайт",
                Parents = new List<StepTypes?>(){ StepTypes.Group, StepTypes.GroupOneOfSubsteps },
                Types = new List<StepTypes>(){ StepTypes.Open, StepTypes.RefreshPage } },
            new StepTypesGroup(){
                ImageIndex = 5,
                Name = "JS действие для элемента",
                Parents = new List<StepTypes?>(){ StepTypes.FindElement },
                Types = new List<StepTypes>(){ StepTypes.JsEvent, StepTypes.ScrollTo } },
            new StepTypesGroup(){
                ImageIndex = 9,
                Name = "Ввод пользователя",
                Parents = new List<StepTypes?>(){ StepTypes.Group, StepTypes.GroupOneOfSubsteps },
                Types = new List<StepTypes>(){ StepTypes.InputToParameterByUser } },
            new StepTypesGroup(){
                ImageIndex = 5,
                Name = "JS действие",
                Parents = new List<StepTypes?>(){ StepTypes.Group, StepTypes.GroupOneOfSubsteps, StepTypes.FindElement },
                Types = new List<StepTypes>(){ StepTypes.ScrollByPixels, StepTypes.JsCode } },
            new StepTypesGroup(){
                ImageIndex = 4,
                Name = "Проверить существование",
                Parents = new List<StepTypes?>(){ StepTypes.Group, StepTypes.GroupOneOfSubsteps, StepTypes.FindElement },
                Types = new List<StepTypes>(){ StepTypes.CheckElement } },
        };

        public static Dictionary<StepTypes, string> Descriptions { get; } = new Dictionary<StepTypes, string>{
            // NEWSTEP add name for step
            { StepTypes.Group, "Группа шагов" },
            { StepTypes.GroupOneOfSubsteps, "Один из подшагов выполняется" }, // Don't stop test, green if any substep green
            { StepTypes.FindElement, "Найти элемент" },
            { StepTypes.WaitTime, "Ждать время" },
            { StepTypes.CheckElement, "Элемента" },

            { StepTypes.JsEvent, "Вызвать событие" },
            { StepTypes.ScrollTo, "Прокрутить страницу к элементу" },

            { StepTypes.ScrollByPixels, "Прокрутить на пиксели" },
            { StepTypes.JsCode, "Вызвать код" },

            { StepTypes.Open, "Открыть сайт" },
            { StepTypes.RefreshPage, "Обновить страницу" },

            { StepTypes.Click, "Клик" },
            { StepTypes.AltClick, "Альтернативный клик" },
            { StepTypes.JsClick, "Клик через JS" },
            { StepTypes.DoubleClick, "Двойной клик" },
            { StepTypes.MouseMoveToEl, "Передвинуть на элемент" },

            { StepTypes.CheckText, "Текст" },
            { StepTypes.CheckAttribute, "Атрибут" },
            { StepTypes.CheckClassExists, "Наличие класса" },
            { StepTypes.CheckClassNotExists, "Отсутствие класса" },
            { StepTypes.CompareParameters, "Сравнить 2 параметра" },

            { StepTypes.EnterText, "Ввести значение" },
            { StepTypes.SetAttribute, "Атрибут" },
            { StepTypes.ClearValue, "Очистить значение" },

            { StepTypes.ReadTextToParameter, "Текст" },
            { StepTypes.ReadAttributeToParameter, "Атрибут" },
            { StepTypes.ReadAddressToParameter, "URL" },

            { StepTypes.InputToParameterByUser, "В параметр" },
        };

        public static int GetIndexOfGroupByType(StepTypes stepType)
        {
            return StepTypesGroups.First(x => x.Types.Contains(stepType)).ImageIndex;
        }

        public static StepTypes GetTypeByNameAndGroup(string name, string groupName)
        {
            var group = StepTypesGroups.FirstOrDefault(x => x.Name == groupName);
            var listOfTypes = Descriptions.Where(x => x.Value == name).Select(x => x.Key);

            foreach (var type in listOfTypes)
            {
                if (group.Types.Contains(type))
                    return type;
            }
            return StepTypes.Group;
        }
    }
}
