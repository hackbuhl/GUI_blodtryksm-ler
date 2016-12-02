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
        int dia_;
        int sys_;
        SoundPlayer simpleSound = new SoundPlayer(@"c:\Users\Sofie Riisberg\Dropbox\Semesterprojekt 3 - Gruppe 4\alarma.wav");

        private int alarmvalues; 
        public int Alarmvalues
        {
            get
            {
                return alarmvalues; 
            }

            set
            {
            }
        }
        public Alarm()
        {
            sys_ = 190;
            dia_ = 70; 
        }

        public void SetAlarm(DTO_alarm dto)
        {
            
        }

        public void alarmSound(int dia, int sys)
        {
            if (dia < dia_ || sys > sys_)
            {
                simpleSound.Play();
            }
        }
        }

        //public void Update(int val)

    }
