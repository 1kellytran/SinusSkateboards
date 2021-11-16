using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboards.Models
{
    public enum Category
    {
        Cap = 1,
        Hoodie,
        Tshirt,

    }

    public enum Color
    {
        Blue,
        Black,
        Green,
        Grey,
        Patterned,
        Pink,
        Purple,
        Red,
        White,
        Yellow
    }

    public enum Size
    {
        [Display(Name = "ONE SIZE")]
        ONE_SIZE,
        S,
        M, 
        L
    }

    public enum Material
    {
        Plastic,
        Wood
    }
    public enum WheelSize
    {
        Fat,
        Slim
    }
}
