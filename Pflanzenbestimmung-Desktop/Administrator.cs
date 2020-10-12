﻿using Newtonsoft.Json;

namespace Pflanzenbestimmung_Desktop
{
    public class Administrator : Benutzer
    {
        public Administrator()
        {
        }

        [JsonConstructor]
        public Administrator(int berflag)
        {
            this.berflag = berflag;
            istAdmin = true;
        }

        new public static Administrator fromTempObjekt(BenutzerTemplate temp)
        {
            Administrator administrator = new Administrator()
            {
                nutzername = temp.nutzername,
                name = temp.name,
                vorname = temp.name,
                berflag = temp.berflag,
                istAdmin = true,
                id_ausbilder = temp.id_ausbilder
            };

            return administrator;
        }
        public override string ToString()
        {
            return nutzername;
        }


        //string name;
        //string vorname;
        //string nutzername;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //public string Vorname
        //{
        //    get { return vorname; }
        //    set { vorname = value; }
        //}
        //public string Nutzername
        //{
        //    get { return nutzername; }
        //    set { nutzername = value; }
        //}

    }
}
