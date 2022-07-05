using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Config : object
{
    public static string myName = "";
    public static int indexPlayer;

    public static string pathGetUsers = "http://support001.ru/Project2.0/Users/getUsers.php";
    public static string pathLoginUsers = "http://support001.ru/Project2.0/Users/login.php";
    public static string pathRegistrationUsers = "http://support001.ru/Project2.0/Users/create.php";

    public static string code200 = "Успешная операция.";
    public static string code400 = "Некоректный ввод данных.";
    public static string code404 = "Не правильный ввод данных.";
    public static string code405 = "Пользователь с таким логином, уже существует.";
}
