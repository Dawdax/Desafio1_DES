using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AP190139Desafio1.Models.Seeds
{
    public class EmpleadoSeed : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.HasData(
                new Empleado { Id = 1, Nombres = "David Alexander", Apellidos = "Aguilar Panameño", FechaDeNacimiento = DateOnly.Parse("06-07-2000"), Direccion = "Apopa,Col. 2, Psj.6, Casa #2", Telefono = "72226082", Cargo = "Programador", SueldoBase = Decimal.Parse("1200") },
                new Empleado { Id = 2, Nombres = "Pedro Felipe", Apellidos = "Perez Guerrero", FechaDeNacimiento = DateOnly.Parse("01-02-1992"), Direccion = "Nejapa,Col. 11, Psj.1, Casa #32", Telefono = "71710021", Cargo = "Vendedor", SueldoBase = Decimal.Parse("550") },
                new Empleado { Id = 3, Nombres = "Sandra Alejandra", Apellidos = "Reyes Flores", FechaDeNacimiento = DateOnly.Parse("09-05-1990"), Direccion = "Aguilares,Col. 2, Psj.4, Casa #12", Telefono = "76663625", Cargo = "Vendedor", SueldoBase = Decimal.Parse("550") },
                new Empleado { Id = 4, Nombres = "Juan Pablo", Apellidos = "Díaz Figueroa", FechaDeNacimiento = DateOnly.Parse("08-12-1993"), Direccion = "Guazapa,Col. 31, Psj.29, Casa #1", Telefono = "74545466", Cargo = "Contador", SueldoBase = Decimal.Parse("650") },
                new Empleado { Id = 5, Nombres = "Mariela Alexandra", Apellidos = "Aguilar Cortez", FechaDeNacimiento = DateOnly.Parse("02-04-1999"), Direccion = "Soyapango,Col. 45, Psj.20, Casa #32", Telefono = "70212325", Cargo = "Vendedor", SueldoBase = Decimal.Parse("575") },
                new Empleado { Id = 6, Nombres = "Roberto Rodrigo", Apellidos = "Lopez Tobar", FechaDeNacimiento = DateOnly.Parse("12-12-2001"), Direccion = "San Marcos,Col. 11, Psj.49, Casa #11", Telefono = "76663636", Cargo = "Supervisor", SueldoBase = Decimal.Parse("600") },
                new Empleado { Id = 7, Nombres = "Brenda Alejandra", Apellidos = "Flores Aguilar", FechaDeNacimiento = DateOnly.Parse("12-02-1996"), Direccion = "Panchimalco,Col. 28, Psj.21, Casa #7", Telefono = "78785525", Cargo = "Programador", SueldoBase = Decimal.Parse("1000") },
                new Empleado { Id = 8, Nombres = "Juan David", Apellidos = "Melara Argueta", FechaDeNacimiento = DateOnly.Parse("12-10-1998"), Direccion = "Apopa,Col. 17, Psj.17, Casa #8", Telefono = "73636399", Cargo = "Contador", SueldoBase = Decimal.Parse("625") },
                new Empleado { Id = 9, Nombres = "Ricardo Mauricio", Apellidos = "Huezo Perez", FechaDeNacimiento = DateOnly.Parse("11-08-1992"), Direccion = "Soyapango,Col. 29, Psj.23, Casa #63", Telefono = "70121589", Cargo = "Bodeguero", SueldoBase = Decimal.Parse("500") },
                new Empleado { Id = 10, Nombres = "Karla Lisset", Apellidos = "Ayala Pineda", FechaDeNacimiento = DateOnly.Parse("15-01-1995"), Direccion = "Nejapa,Col. 39, Psj.36, Casa #13", Telefono = "71477701", Cargo = "Bodeguero", SueldoBase = Decimal.Parse("525") }
                );
        }
    }
}
