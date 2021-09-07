using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class EShopModel
    {
        public enum Sections
        {
            Search=0,
            Discover,
            RecentReleases,
            CurrentOffers,
            Charts,
            ComingSoon,
            NintendoSwitchOnline,
            RedeemCode,
        }

        readonly Dictionary<Sections,Section> _sections;

        static EShopModel _instance;
        
        public static EShopModel Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;

                _instance = new EShopModel();
                return _instance;
            }
         }

        EShopModel()
        {
            _sections = new Dictionary<Sections, Section>
            {
                {Sections.Search,new Search()},
                {Sections.Discover,new Discover()},
                {Sections.RecentReleases,new RecentReleases()},
                {Sections.CurrentOffers,new CurrentOffers()},
                {Sections.Charts,new Charts()},
                {Sections.ComingSoon,new ComingSoon()},
                {Sections.NintendoSwitchOnline,new NintendoSwitchOnline()},
                {Sections.RedeemCode,new RedeemCode()},
            };
        }

        public T GetSection<T>() where T: class, Section
        {
            var result = _sections.Values.ToList().Find(section => section.GetType() == typeof(T));
            return result as T;
        }

        public Section GetSection(Sections section)
        {
            return _sections[section];
        }
        public List<Section> GetAllSections()
        {
            return _sections.Values.ToList();
        }
    }

    public interface Section
    {
        
    }

    public class Search : Section
    {
      
    }

    public class Discover:Section
    {
    }

    public class RecentReleases:Section
    {
       
    }

    public class CurrentOffers:Section
    {
       
    }

    public class Charts:Section
    {
       
    }

    public class ComingSoon : Section
    {
    }

    public class NintendoSwitchOnline:Section
    {
      
    }

    public class RedeemCode : Section
    {
        
    }
    

}
