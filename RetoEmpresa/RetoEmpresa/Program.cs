using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "", elemento = "", simbolo = "", linea;
            int numeroAtomico = 0, resultado = 0;

            do
            {
                Console.Write("Ingrese el Numero Atomico del Elemento en Consulta o escriba 'Exit' para Salir.\n");
                linea = Console.ReadLine();

                if (int.TryParse(linea, out int result))
                {
                    numeroAtomico = int.Parse(linea);
                    switch (numeroAtomico)
                    {
                        case 1:
                            { elemento = "Hidrógeno"; simbolo = "H"; }
                            break;
                        case 2:
                            { elemento = "Helio"; simbolo = "He"; }
                            break;
                        case 3:
                            { elemento = "Litio"; simbolo = "Li"; }
                            break;
                        case 4:
                            { elemento = "Berilio"; simbolo = "Be"; }
                            break;
                        case 5:
                            { elemento = "Boro"; simbolo = "B"; }
                            break;
                        case 6:
                            { elemento = "Carbono"; simbolo = "C"; }
                            break;
                        case 7:
                            { elemento = "Nitrógeno"; simbolo = "N"; }
                            break;
                        case 8:
                            { elemento = "Oxígeno"; simbolo = "O"; }
                            break;
                        case 9:
                            { elemento = "Flúor"; simbolo = "F"; }
                            break;
                        case 10:
                            { elemento = "Neón"; simbolo = "Ne"; }
                            break;
                        case 11:
                            { elemento = "Sodio"; simbolo = "Na"; }
                            break;
                        case 12:
                            { elemento = "Magnesio"; simbolo = "Mg"; }
                            break;
                        case 13:
                            { elemento = "Aluminio"; simbolo = "Al"; }
                            break;
                        case 14:
                            { elemento = "Silicio"; simbolo = "Si"; }
                            break;
                        case 15:
                            { elemento = "Fósforo"; simbolo = "P"; }
                            break;
                        case 16:
                            { elemento = "Azufre"; simbolo = "S"; }
                            break;
                        case 17:
                            { elemento = "Cloro"; simbolo = "Cl"; }
                            break;
                        case 18:
                            { elemento = "Argón"; simbolo = "Ar"; }
                            break;
                        case 19:
                            { elemento = "Potasio"; simbolo = "K"; }
                            break;
                        case 20:
                            { elemento = "Calcio"; simbolo = "Ca"; }
                            break;
                        case 21:
                            { elemento = "Escandio"; simbolo = "Sc"; }
                            break;
                        case 22:
                            { elemento = "Titanio"; simbolo = "Ti"; }
                            break;
                        case 23:
                            { elemento = "Vanadio"; simbolo = "V"; }
                            break;
                        case 24:
                            { elemento = "Cromo"; simbolo = "Cr"; }
                            break;
                        case 25:
                            { elemento = "Manganeso"; simbolo = "Mn"; }
                            break;
                        case 26:
                            { elemento = "Hierro"; simbolo = "Fe"; }
                            break;
                        case 27:
                            { elemento = "Cobalto"; simbolo = "Co"; }
                            break;
                        case 28:
                            { elemento = "Niquel"; simbolo = "Ni"; }
                            break;
                        case 29:
                            { elemento = "Cobre"; simbolo = "Cu"; }
                            break;
                        case 30:
                            { elemento = "Zinc"; simbolo = "Zn"; }
                            break;
                        case 31:
                            { elemento = "Galio"; simbolo = "Ga"; }
                            break;
                        case 32:
                            { elemento = "Germanio"; simbolo = "Ge"; }
                            break;
                        case 33:
                            { elemento = "Arsénico"; simbolo = "As"; }
                            break;
                        case 34:
                            { elemento = "Selenio"; simbolo = "Se"; }
                            break;
                        case 35:
                            { elemento = "Bromo"; simbolo = "Br"; }
                            break;
                        case 36:
                            { elemento = "Kriptón"; simbolo = "Kr"; }
                            break;
                        case 37:
                            { elemento = "Rubidio"; simbolo = "Rb"; }
                            break;
                        case 38:
                            { elemento = "Estroncio"; simbolo = "Sr"; }
                            break;
                        case 39:
                            { elemento = "Itrio"; simbolo = "Y"; }
                            break;
                        case 40:
                            { elemento = "Circonio"; simbolo = "Zr"; }
                            break;
                        case 41:
                            { elemento = "Niobio"; simbolo = "Nb"; }
                            break;
                        case 42:
                            { elemento = "Molibdeno"; simbolo = "Mo"; }
                            break;
                        case 43:
                            { elemento = "Tecnecio"; simbolo = "Tc"; }
                            break;
                        case 44:
                            { elemento = "Rutenio"; simbolo = "Ru"; }
                            break;
                        case 45:
                            { elemento = "Rodio"; simbolo = "Rh"; }
                            break;
                        case 46:
                            { elemento = "Paladio"; simbolo = "Pd"; }
                            break;
                        case 47:
                            { elemento = "Plata"; simbolo = "Ag"; }
                            break;
                        case 48:
                            { elemento = "Cadmio"; simbolo = "Cd"; }
                            break;
                        case 49:
                            { elemento = "Indio"; simbolo = "In"; }
                            break;
                        case 50:
                            { elemento = "Estaño"; simbolo = "Sn"; }
                            break;
                        case 51:
                            { elemento = "Antimonio"; simbolo = "Sb"; }
                            break;
                        case 52:
                            { elemento = "Telurio"; simbolo = "Te"; }
                            break;
                        case 53:
                            { elemento = "Yodo"; simbolo = "I"; }
                            break;
                        case 54:
                            { elemento = "Xenón"; simbolo = "Xe"; }
                            break;
                        case 55:
                            { elemento = "Cesio"; simbolo = "Cs"; }
                            break;
                        case 56:
                            { elemento = "Bario"; simbolo = "Ba"; }
                            break;
                        case 57:
                            { elemento = "Lantano"; simbolo = "La"; }
                            break;
                        case 58:
                            { elemento = "Cerio"; simbolo = "Ce"; }
                            break;
                        case 59:
                            { elemento = "Praseodimio"; simbolo = "Pr"; }
                            break;
                        case 60:
                            { elemento = "Neodimio"; simbolo = "Nd"; }
                            break;
                        case 61:
                            { elemento = "Prometio"; simbolo = "Pm"; }
                            break;
                        case 62:
                            { elemento = "Samario"; simbolo = "Sm"; }
                            break;
                        case 63:
                            { elemento = "Europio"; simbolo = "Eu"; }
                            break;
                        case 64:
                            { elemento = "Gadolinio"; simbolo = "Gd"; }
                            break;
                        case 65:
                            { elemento = "Terbio"; simbolo = "Tb"; }
                            break;
                        case 66:
                            { elemento = "Disprosio"; simbolo = "Dy"; }
                            break;
                        case 67:
                            { elemento = "Holmio"; simbolo = "Ho"; }
                            break;
                        case 68:
                            { elemento = "Erbio"; simbolo = "Er"; }
                            break;
                        case 69:
                            { elemento = "Tulio"; simbolo = "Tm"; }
                            break;
                        case 70:
                            { elemento = "Iterbio"; simbolo = "Yb"; }
                            break;
                        case 71:
                            { elemento = "Lutecio"; simbolo = "Lu"; }
                            break;
                        case 72:
                            { elemento = "Hafnio"; simbolo = "Hf"; }
                            break;
                        case 73:
                            { elemento = "Tántalo"; simbolo = "Ta"; }
                            break;
                        case 74:
                            { elemento = "Wolframio"; simbolo = "W"; }
                            break;
                        case 75:
                            { elemento = "Renio"; simbolo = "Re"; }
                            break;
                        case 76:
                            { elemento = "Osmio"; simbolo = "Os"; }
                            break;
                        case 77:
                            { elemento = "Iridio"; simbolo = "Ir"; }
                            break;
                        case 78:
                            { elemento = "Platino"; simbolo = "Pt"; }
                            break;
                        case 79:
                            { elemento = "Oro"; simbolo = "Au"; }
                            break;
                        case 80:
                            { elemento = "Mercurio"; simbolo = "Hg"; }
                            break;
                        case 81:
                            { elemento = "Talio"; simbolo = "Tl"; }
                            break;
                        case 82:
                            { elemento = "Plomo"; simbolo = "Pb"; }
                            break;
                        case 83:
                            { elemento = "Bismuto"; simbolo = "Bi"; }
                            break;
                        case 84:
                            { elemento = "Polonio"; simbolo = "Po"; }
                            break;
                        case 85:
                            { elemento = "Astato"; simbolo = "At"; }
                            break;
                        case 86:
                            { elemento = "Radón"; simbolo = "Rn"; }
                            break;
                        case 87:
                            { elemento = "Francio"; simbolo = "Fr"; }
                            break;
                        case 88:
                            { elemento = "Radio"; simbolo = "Ra"; }
                            break;
                        case 89:
                            { elemento = "Actinio"; simbolo = "Ac"; }
                            break;
                        case 90:
                            { elemento = "Torio"; simbolo = "Th"; }
                            break;
                        case 91:
                            { elemento = "Protactinio"; simbolo = "Pa"; }
                            break;
                        case 92:
                            { elemento = "Uranio"; simbolo = "U"; }
                            break;
                        case 93:
                            { elemento = "Neptunio"; simbolo = "Np"; }
                            break;
                        case 94:
                            { elemento = "Plutonio"; simbolo = "Pu"; }
                            break;
                        case 95:
                            { elemento = "Americio"; simbolo = "Am"; }
                            break;
                        case 96:
                            { elemento = "Curio"; simbolo = "Cm"; }
                            break;
                        case 97:
                            { elemento = "Berkelio"; simbolo = "Bk"; }
                            break;
                        case 98:
                            { elemento = "Californio"; simbolo = "Cf"; }
                            break;
                        case 99:
                            { elemento = "Einstenio"; simbolo = "Es"; }
                            break;
                        case 100:
                            { elemento = "Fermio"; simbolo = "Fm"; }
                            break;
                        case 101:
                            { elemento = "Mendelevio"; simbolo = "Md"; }
                            break;
                        case 102:
                            { elemento = "Nobelio"; simbolo = "No"; }
                            break;
                        case 103:
                            { elemento = "Lawrencio"; simbolo = "Lr"; }
                            break;
                        case 104:
                            { elemento = "Rutherfordio"; simbolo = "Rf"; }
                            break;
                        case 105:
                            { elemento = "Dubnio"; simbolo = "Db"; }
                            break;
                        case 106:
                            { elemento = "Seaborgio"; simbolo = "Sg"; }
                            break;
                        case 107:
                            { elemento = "Bohrio"; simbolo = "Bh"; }
                            break;
                        case 108:
                            { elemento = "Hasio"; simbolo = "Hs"; }
                            break;
                        case 109:
                            { elemento = "Meitnerio"; simbolo = "Mt"; }
                            break;
                        case 110:
                            { elemento = "Darmstatio"; simbolo = "Ds"; }
                            break;
                        case 111:
                            { elemento = "Roentgenio"; simbolo = "Rg"; }
                            break;
                        case 112:
                            { elemento = "Copernicio"; simbolo = "Cn"; }
                            break;
                        case 113:
                            { elemento = "Nihonio"; simbolo = "Nh"; }
                            break;
                        case 114:
                            { elemento = "Flerovio"; simbolo = "Fl"; }
                            break;
                        case 115:
                            { elemento = "Moscovio"; simbolo = "Mc"; }
                            break;
                        case 116:
                            { elemento = "Livermorio"; simbolo = "Lv"; }
                            break;
                        case 117:
                            { elemento = "Teneso"; simbolo = "Ts"; }
                            break;
                        case 118:
                            { elemento = "Oganessón"; simbolo = "Og"; }
                            break;
                    } //Elementos
                    {
                        if (numeroAtomico <= 2)
                        {
                            resultado = numeroAtomico;
                            texto = "1s";
                        }
                        else if (numeroAtomico <= 4)
                        {
                            texto = "1s2 2s";
                            resultado = numeroAtomico - 2;
                        }
                        else if (numeroAtomico <= 10)
                        {
                            resultado = numeroAtomico - 4;
                            texto = "1s2 2s2 2p";
                        }
                        else if (numeroAtomico <= 12)
                        {
                            resultado = numeroAtomico - 10;
                            texto = "1s2 2s2 2p6 3s";
                        }
                        else if (numeroAtomico <= 18)
                        {
                            resultado = numeroAtomico - 12;
                            texto = "1s2 2s2 2p6 3s2 3p";
                        }
                        else if (numeroAtomico <= 20)
                        {
                            resultado = numeroAtomico - 18;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s";
                        }
                        else if (numeroAtomico <= 30)
                        {
                            resultado = numeroAtomico - 20;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d";
                        }
                        else if (numeroAtomico <= 36)
                        {
                            resultado = numeroAtomico - 30;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p";
                        }
                        else if (numeroAtomico <= 38)
                        {
                            resultado = numeroAtomico - 36;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s";
                        }
                        else if (numeroAtomico <= 48)
                        {
                            resultado = numeroAtomico - 38;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d";
                        }
                        else if (numeroAtomico <= 54)
                        {
                            resultado = numeroAtomico - 48;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p";
                        }
                        else if (numeroAtomico <= 56)
                        {
                            resultado = numeroAtomico - 54;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s";
                        }
                        else if (numeroAtomico <= 70)
                        {
                            resultado = numeroAtomico - 56;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f";
                        }
                        else if (numeroAtomico <= 80)
                        {
                            resultado = numeroAtomico - 70;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d";
                        }
                        else if (numeroAtomico <= 86)
                        {
                            resultado = numeroAtomico - 80;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p";
                        }
                        else if (numeroAtomico <= 88)
                        {
                            resultado = numeroAtomico - 86;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s";
                        }
                        else if (numeroAtomico <= 102)
                        {
                            resultado = numeroAtomico - 88;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f";
                        }
                        else if (numeroAtomico <= 112)
                        {
                            resultado = numeroAtomico - 102;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d";
                        }
                        else if (numeroAtomico <= 118)
                        {
                            resultado = numeroAtomico - 112;
                            texto = "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d10 7p";
                        }
                        else
                        {
                            texto = "Exit";
                        }
                    } //Configuración Atomica
                    Console.Clear();
                    Console.Write("Elemento: " + elemento + "\nSimbolo: " + simbolo + "\nNúmero Atomico: " + numeroAtomico + "\nConfiguración Electronica:\n" + texto + resultado);
                    Console.ReadKey();
                }
                else
                {
                    if (linea.Equals("Exit"))
                    {
                        Environment.Exit(1);
                    }
                    else
                    {
                        linea = "";
                    }
                }
            }
            while (linea.Equals(""));


        }
    }
}
