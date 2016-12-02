using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_blodtryksmåler;
using System.Media;


namespace Logic_blodtryksmåler
{
    public class Alarm
    {
        private DTO_alarm dtoAlarm = new DTO_alarm();
        private int dia_nedre;
        private int dia_øvre;
        private int sys_nedre;
        private int sys_øvre;

        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Sofie Riisberg\Documents\GitHub\GUI_blodtryksm-ler\GUI_blodtryksmåler\bin\Debug\signal.wav");

        public Alarm()
        {
            sys_nedre = 100;
            sys_øvre = 190;
            dia_nedre = 60;
            dia_øvre = 100;  
        }

        public Alarm(DTO_alarm dto)
        {
            dia_nedre = dto.NedDia;
            dia_øvre = dto.ØvDia;
            sys_nedre = dto.NedSys;
            sys_øvre = dto.ØvSys;
        }


        public void alarmSound(DTO_alarm dto)
        {
            if (dto.NedDia < dia_nedre || dto.ØvDia > dia_øvre || dto.NedSys < sys_nedre || dto.ØvSys > sys_øvre)
            {
                simpleSound.Play();
            }
        }
        

        //public void Update(int val)
<<<<<<< HEAD
        //{
            
        //}
=======

>>>>>>> origin/master
    }
