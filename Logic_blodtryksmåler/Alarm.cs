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

        SoundPlayer simpleSound =
            new SoundPlayer(
                @"C:\Users\Daniel\Documents\GitHub\GUI_blodtryksm-ler\GUI_blodtryksmåler\bin\Debug\signal.wav");

        public Alarm()
        {
            sys_nedre = 100;
            sys_øvre = 190;
            dia_nedre = 60;
            dia_øvre = 130;
        }

        public void setAlarm(DTO_alarm dto)
        {
            dia_nedre = dto.NedDia;
            dia_øvre = dto.ØvDia;
            sys_nedre = dto.NedSys;
            sys_øvre = dto.ØvSys;
        }


        public void alarmSound(ref  DTO_data dto)
        {
            if (dto.Diastole< dia_nedre || dto.Diastole > dia_øvre || dto.Systole < sys_nedre || dto.Systole > sys_øvre)
            {
                simpleSound.PlayLooping();
            }
            else if (dto.Diastole > dia_nedre & dto.Diastole < dia_øvre & dto.Systole > sys_nedre & dto.Systole < sys_øvre)
            {
                stopAlarm();
            }
        }

        public void stopAlarm()
        {
            simpleSound.Stop();
        }



    }
}
