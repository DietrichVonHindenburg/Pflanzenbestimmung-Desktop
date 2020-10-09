﻿using Newtonsoft.Json;

namespace Pflanzenbestimmung_Desktop
{
    public class Pflanze
    {
        public int id_pflanze;
        public int zierpflanzenbau;
        public int gartenlandschaftsbau;
        //[JsonProperty("0")]
        public KategorieAbfrage[] kategorien;


        public bool IstGala
        {
            get
            {
                return gartenlandschaftsbau != 0;
            }
        }

        public bool IstZier
        {
            get
            {
                return zierpflanzenbau != 0;
            }
        }
    }
}
