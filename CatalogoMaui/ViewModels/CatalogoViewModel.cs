
using System.Collections.Generic;
using CatalogoMaui.Models;

namespace CatalogoMaui.ViewModels;

public class CatalogoViewModel
{
    public List<Producto> Productos { get; } = new()
    {
        new Producto
        {
            Nombre = "Mochila urbana",
            Descripcion = "Con espacio para laptop y cuadernos.",
            Precio = 499.00m,
            Foto = "mochila.png",
            Detalle = "Mochila de uso diario con compartimento acolchado para laptop y un bolsillo frontal para guardar objetos pequeños."
        },

        new Producto
        {
            Nombre = "Libreta A5",
            Descripcion = "80 hojas rayadas con pasta dura.",
            Precio = 89.50m,
            Foto = "libreta.png",
            Detalle = "Libreta de tamaño A5 con 80 hojas rayadas. Su pasta dura protege los apuntes y facilita su transporte."
        },

        new Producto
        {
            Nombre = "Termo de acero",
            Descripcion = "Botella reutilizable de 500 ml.",
            Precio = 219.00m,
            Foto = "termo.png",
            Detalle = "Termo reutilizable de acero con capacidad de 500 ml. Es práctico para llevar bebidas durante el día."
        },

        new Producto
        {
            Nombre = "Audífonos inalámbricos",
            Descripcion = "Audífonos cómodos para escuchar música.",
            Precio = 349.00m,
            Foto = "audifonos.png",
            Detalle = "Audífonos inalámbricos diseñados para escuchar música y disfrutar de contenido multimedia cómodamente."
        }
    };
}
