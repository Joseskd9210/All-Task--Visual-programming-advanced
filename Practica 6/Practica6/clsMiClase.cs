using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica6
{
    class clsMiClase
    {

        private string p_nombre;
        public string nombre
    {
    get
    {
    return p_nombre;
    }
    set
    {
    p_nombre=value; 
    }
}

private string p_nif;
public string nif
{
get
{
return p_nif;
}
set
{
p_nif=value;
}
}
private int p_edad;
public int edad
{
get
{
return p_edad;
}
set
{
if (value > 0) p_edad=value;
}
}
public long suma(int num1, int num2)
{
return num1 + num2;
}
public int sumadeedades(int edad1, int edad2)
{
    return edad1 + edad2;
}
public clsMiClase(string anombre, string anif, int aedad)   
{
this.nombre=anombre;
this.nif=anif;
this.edad=aedad;
}
}
}
