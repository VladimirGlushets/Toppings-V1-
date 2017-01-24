using Topping.Common.Sources;
using Topping.Domain.Models;

namespace Topping.Domain.Extentions
{
    public static class GroupEnumExt
    {
        public static string GetValue(this GroupEnum group)
        {
            switch (group)
            {
                case GroupEnum.Berry:
                    return GroupName.BerryGroup;
                case GroupEnum.Fruit:
                    return GroupName.FruitGroup;
                case GroupEnum.Cocktail:
                    return GroupName.CocktailGroup;
                case GroupEnum.Coffee:
                    return GroupName.CoffeeGroup;

                default:
                    return string.Empty;
            }
        }

        public static string GetDescription(this GroupEnum group)
        {
            switch (group)
            {
                case GroupEnum.Berry:
                    return GroupDescription.BerryGroup;
                case GroupEnum.Fruit:
                    return GroupDescription.FruitGroup;
                case GroupEnum.Cocktail:
                    return GroupDescription.CocktailGroup;
                case GroupEnum.Coffee:
                    return GroupDescription.CoffeeGroup;

                default:
                    return string.Empty;
            }
        }

        public static string GetImagePath(this GroupEnum group)
        {
            switch (group)
            {
                case GroupEnum.Berry:
                    return "berries-group.png";
                case GroupEnum.Fruit:
                    return "fruit-group.png";
                case GroupEnum.Cocktail:
                    return "coctail-group.png";
                case GroupEnum.Coffee:
                    return "coffee-group.png";

                default:
                    return string.Empty;
            }
        }

        //public static string GetImagePath(this GroupEnum group)
        //{
        //    switch (group)
        //    {
        //        case GroupEnum.Berry:
        //            return "~/Content/Images/Groups/berries-group.png";
        //        case GroupEnum.Fruit:
        //            return "~/Content/Images/Groups/fruit-group.png";
        //        case GroupEnum.Cocktail:
        //            return "~/Content/Images/Groups/coctail-group.png";
        //        case GroupEnum.Coffee:
        //            return "~/Content/Images/Groups/coffee-group.png";

        //        default:
        //            return string.Empty;
        //    }
        //}
    }
}
