using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public string Type { get; set; }
        public int Capacity {  get; set; }
        private List<Cloth>_clothes;
        public List<Cloth> Clothes=>_clothes;

        public Magazine(string type, int capacity)
        {
            Type=type;
            Capacity=capacity;

            _clothes=new List<Cloth>();
        }
        public void AddCloth(Cloth cloth)
        {
            if (_clothes.Count<Capacity)
            {
                _clothes.Add(cloth);
            }
        }
        public bool RemoveCloth(string color)
        {
            Cloth cloth=_clothes.FirstOrDefault(c=>c.Color==color);
            if (cloth!=null)
            {
                _clothes.Remove(cloth);
                return true;
            }
            return false;
        }
        public Cloth GetSmallestCloth()
        {
            return _clothes.OrderBy(c => c.Size).FirstOrDefault();
        }
        public Cloth GetCloth(string color)
        {
            return _clothes.FirstOrDefault(c=>c.Color==color);
        }
        public int GetClothCount()=>_clothes.Count;

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($" {Type} magazine contains:");
            var result=_clothes.OrderBy(c=>c.Size).ToList();
            foreach (Cloth item in result)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            return stringBuilder.ToString().Trim();    
        }


    }
}
