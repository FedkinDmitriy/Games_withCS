﻿using System;

namespace GuessNumber_CS
{
    public delegate int UserInput(); //делегат для вользовательского ввода
    public delegate void GetStatus(string message); //делегат для вывода сообщений

    public class Randomizer
    {
        private UserInput _usr;
        private GetStatus _sts;
        private int _from, _to;
        private int _guessNumber;
        private bool isGuess = true;

        public Randomizer(int from = 0, int to = 100)
        {
            _from = from;
            _to = to;
            _guessNumber = new Random().Next(_from, _to);
        }
        /// <summary>
        /// Регистрация делегатов для использования класса
        /// </summary>
        /// <param name="del1"></param>
        /// <param name="del2"></param>
        /// <returns></returns>
        public bool RegisterDelegats(UserInput del1, GetStatus del2)
        {
            _usr = del1;
            _sts = del2;
            if (_usr != null && _sts != null)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Запуск игры
        /// </summary>
        public void LetsPlay()
        {
            while (isGuess)
            {
                int? userInput = _usr?.Invoke();

                if (userInput != _guessNumber)
                {
                    if (userInput < _guessNumber)
                    {
                        _sts?.Invoke($"Твоё число меньше загаданного, попробуй ещё");
                    }
                    else if (userInput > _guessNumber)
                    {
                        _sts?.Invoke($"Твоё число больше загаданного, попробуй ещё");
                    }
                }
                else
                {
                    _sts?.Invoke($"Ты угадал, поздравляю !!!");
                    isGuess = false;
                }
            }

        }

    }
}
