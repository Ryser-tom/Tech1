using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace ascenseur
{
    public class SerialData
    {

        private ascenseur _ascens;

        public ascenseur Ascens
        {
            get { return _ascens; }
            set { _ascens = value; }
        }

        private void WriteXMLData(Object T, string path)
        {
            XmlSerializer formatter = new XmlSerializer(T.GetType());
            StreamWriter f = null;
            try {
                f = new StreamWriter(path);
                formatter.Serialize(f, T);
                f.Flush();
            } catch (Exception) {

            } finally {
                if (f != null) {
                    f.Close();
                }
            }
        }

        private T LoadXMLFile<T>(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            StreamReader f = null;
            try {
                f = new StreamReader(path);
                return (T)formatter.Deserialize(f);
            } catch (Exception) {
                return default(T);
            } finally {
                if (f != null) {
                    f.Close();
                }
            }
        }

        public SerialData(ascenseur ascens)
        {
            // TODO: Complete member initialization
            this.Ascens = ascens;
            this.Init_Ascenceur();
        }

        public void SetData()
        {
            DataAscenseur dataAscenseur = new DataAscenseur(this.Ascens, this.Ascens.MinEtages, this.Ascens.MaxEtages, this.Ascens.MaxPers);

            List<DataAscenseur> lstDataAscenseur = this.LoadXMLFile<List<DataAscenseur>>("data.xml");

            if (lstDataAscenseur == null) {
                lstDataAscenseur = new List<DataAscenseur>();
                dataAscenseur.SetDatas();
                lstDataAscenseur.Add(dataAscenseur);
            } else {
                dataAscenseur.SetDatas();
                lstDataAscenseur.Add(dataAscenseur);
            }
            this.Ascens.RecordsCount = lstDataAscenseur.Count;
            this.WriteXMLData(lstDataAscenseur, "data.xml");
        }

        public void GetData()
        {
            DataAscenseur dataAscenseur = new DataAscenseur(this.Ascens, this.Ascens.MinEtages, this.Ascens.MaxEtages, this.Ascens.MaxPers);
            List<DataAscenseur> lstDataAscenceur = this.LoadXMLFile<List<DataAscenseur>>("data.xml");
            if (lstDataAscenceur == null) {
                lstDataAscenceur = new List<DataAscenseur>();
                dataAscenseur.SetDatas();
                lstDataAscenceur.Add(dataAscenseur);
            } else {
                dataAscenseur.GetDatas(lstDataAscenceur);
            }
        }

        public void Init_Ascenceur()
        {
            try {
                File.Delete("data.xml");
            } catch (IOException) {

            }
        }
    }
}