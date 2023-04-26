using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerStats : CharacterStats
{
    public List<AbilityBase> skillStats;
    private void OnEnable()
    {
        MainEventBus.EventActionWithSkill += CheckActionWithSkill;
    }
    private void OnDisable()
    {
        MainEventBus.EventActionWithSkill -= CheckActionWithSkill;
    }

    private void CheckActionWithSkill(AbilityBase skillStat, int newExp)
    {
        if (!skillStats.Contains(skillStat))
            skillStats.Add(skillStat);

        AbilityBase skill = skillStats.Find(x => skillStat);

        Debug.Log("new skill or upadte: " + skill.name);

        // у предмета будет навык и при первом использованни будет выучен на постоянной основе 
        // но для использования нужно будет иметь нужный предмет, топор, кирку и т.д.

        /*пример события, если игрок рубит деревья и до этого у него
         * не было навыка рубки деревьев то он получает навык
         * если есть навык то получает опыт
         * проверка после получения опыта на условие получения следующего уровня
         * каждый навык свой класс
         * в нем происходит своя проверка на условия
         * в базовом классе навыка объявить метод добавлеия опыта 
         * также проверки на новый уровень
         * в базовый класс навыка добавить абстрактный метод действия
         * так как к примеру навык стройки не может наносить урона
         * также навык стройки должен быть разделен на как минимум 2 типа
         * 1 тип строительство, 2 тип ремонт поврежденных объектов
         */
    }
}
