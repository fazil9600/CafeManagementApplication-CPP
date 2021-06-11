using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_Management_System
{
    class Cafe
    {

        // Default Constructor
        public Cafe()
        {
            cldlatte = 0.0;
            cldEspresso = 0.0;
            cldIceLatte = 0.0;
            cldValeCofee = 0.0;
            cldMangoJ = 0.0;
            cldBananaS = 0.0;
            cldItalianS = 0.00;
            cldMunchiL = 0.0;



            cleVanilaC = 0.0;
            clePieD = 0.0;
            cleMangoC = 0.0;
            cleSweetP = 0.0;
            cleKimbulaB = 0.0;
            cleMaluP = 0.0;
            cleWade = 0.0;
            cleAthirasa = 0.0;
        }

        //Overload constructor

        public Cafe(double dlatteTotal, double dEspressoTotal, double dIceLatteTotal, double dValeCofeeTotal, double dMangoJTotal, double dBananaSTotal, double dItalianSTotal, double dMunchiLTotal, double eVanilaCTotal, double ePieDTotal, double eMangoCTotal, double eSweetPTotal, double eKimbulaBTotal, double eMaluPTotal, double eWadeTotal, double eAthirasaTotal)
        {

            //for drinks
            cldlatte = dlatteTotal;
            cldEspresso = dEspressoTotal;
            cldIceLatte = dIceLatteTotal;
            cldValeCofee = dValeCofeeTotal;
            cldMangoJ = dMangoJTotal;
            cldBananaS = dBananaSTotal;
            cldItalianS = dItalianSTotal;
            cldMunchiL = dMunchiLTotal;

            //for eatings

            cleVanilaC = eVanilaCTotal;
            clePieD = ePieDTotal;
            cleMangoC = eMangoCTotal;
            cleSweetP = eSweetPTotal;
            cleKimbulaB = eKimbulaBTotal;
            cleMaluP = eMaluPTotal;
            cleWade = eWadeTotal;
            cleAthirasa = eAthirasaTotal;

        }

        //Accessor Function//


        //Accessor function for drinks

        public double getcldlatte()
        {
            return cldlatte;
        }


        public double getcldEspresso()
        {
            return cldEspresso;
        }

        public double getcldIceLatte()
        {
            return cldIceLatte;
        }

        public double getcldValeCofee()
        {
            return cldValeCofee;
        }

        public double getcldBananaS()
        {
            return cldBananaS;
        }

        public double getcldMangoJ()
        {
            return cldMangoJ;
        }

        public double getcldMunchiL()
        {
            return cldMunchiL;
        }


        //Accessor function for eatings


        public double getcleVanilaC()
        {
            return cleVanilaC;
        }

        public double getclePieD()
        {
            return clePieD;
        }


        public double getcleMangoC()
        {
            return cleMangoC;
        }

        public double getcleSweetP()
        {
            return cleSweetP;
        }

        public double getcleKimbulaB()
        {
            return cleKimbulaB;
        }

        public double getcleMaluP()
        {
            return cleMaluP;
        }

        public double getcleWade()
        {
            return cleWade;
        }

        public double getcleAthirasa()
        {
            return cleAthirasa;
        }




        //Member variables declared for drinks//
        //Here declared as private just to encapsulate//

        private double cldlatte;
        private double cldEspresso;
        private double cldIceLatte;
        private double cldValeCofee;
        private double cldMangoJ;
        private double cldBananaS;
        private double cldItalianS;
        private double cldMunchiL;

        //Member variables declared for drinks//

        private double cleVanilaC;
        private double clePieD;
        private double cleMangoC;
        private double cleSweetP;
        private double cleKimbulaB;
        private double cleMaluP;
        private double cleWade;
        private double cleAthirasa;

    }
}
