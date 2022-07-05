using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Config : object
{
    public static string myName = "";

    public static string pathGetUsers = "http://support001.ru/Project2.0/Users/getUsers.php";
    public static string pathLoginUsers = "http://support001.ru/Project2.0/Users/login.php";
    public static string pathRegistrationUsers = "http://support001.ru/Project2.0/Users/create.php";

    public static string code200 = "�������� ��������.";
    public static string code400 = "����������� ���� ������.";
    public static string code404 = "�� ���������� ���� ������.";
    public static string code405 = "������������ � ����� �������, ��� ����������.";
}
