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
        private int _pieces;
        private double _totalKg;
       private readonly List<PartOfParcelModel> _partsOfParcel;

        public ParcelModel(List<PartOfParcelModel> partsOfParcel)
        {

            _partsOfParcel = partsOfParcel;
        }
       
        public int Pieces
        {
            get => _pieces;
            set
            {
                var count = _partsOfParcel.Count;
                _pieces = count;
            }
        }
        public double TotalKg
        {
            get => _totalKg;
            set
            {
                double sumKg = 0.000;
                _partsOfParcel.ForEach(p => p.Kg += sumKg);
                _totalKg = sumKg;
            }
        }
        public ICollection<PartOfParcelModel> PartsOfParcel { get; set; }
        
    }
}
