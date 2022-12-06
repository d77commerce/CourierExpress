using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CourierExpress.Core.Contracts;
using Newtonsoft.Json;

namespace CourierExpress.Core.Models.Parcel
{
    public class ParcelModel :IParcel
    {
        private readonly List<PartOfParcelModel> partsOfParcel;

        public ParcelModel(List<PartOfParcelModel> _partsOfParcel)
        {

            partsOfParcel = _partsOfParcel;
        }
       
        public int Pieces
        {
            get => Pieces;
            set
            {
                var count = partsOfParcel.Count;
                Pieces = count;
            }
        }


        public double TotalKg
        {
            get => TotalKg;
            set
            {
                double sumKg = 0.000;
                partsOfParcel.ForEach(p => p.Kg += sumKg);
                TotalKg = sumKg;
            }
        }

       
        public string PartsInfoJson
        {
            get => PartsInfoJson;
            set => JsonConvert.SerializeObject(partsOfParcel);
        }
    }
}
