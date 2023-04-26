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

        // � �������� ����� ����� � ��� ������ ������������� ����� ������ �� ���������� ������ 
        // �� ��� ������������� ����� ����� ����� ������ �������, �����, ����� � �.�.

        /*������ �������, ���� ����� ����� ������� � �� ����� � ����
         * �� ���� ������ ����� �������� �� �� �������� �����
         * ���� ���� ����� �� �������� ����
         * �������� ����� ��������� ����� �� ������� ��������� ���������� ������
         * ������ ����� ���� �����
         * � ��� ���������� ���� �������� �� �������
         * � ������� ������ ������ �������� ����� ��������� ����� 
         * ����� �������� �� ����� �������
         * � ������� ����� ������ �������� ����������� ����� ��������
         * ��� ��� � ������� ����� ������� �� ����� �������� �����
         * ����� ����� ������� ������ ���� �������� �� ��� ������� 2 ����
         * 1 ��� �������������, 2 ��� ������ ������������ ��������
         */
    }
}
