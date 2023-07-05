﻿using System;
using ScreenSound.View;

namespace ScreenSound{
    public class ScreenSound{
        public static void Main(){
            
            try{
                ApresentacaoScreenSound.EscreveScreenSound();

                Menu menu = new Menu();

                menu.Main();
            }
            catch(Exception e){

                Console.WriteLine(e.Message);

            }
        }
    }
}