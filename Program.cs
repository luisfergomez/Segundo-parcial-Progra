using System;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario[] lista = new Usuario[15];
            Usuario usuario = new Usuario(null,null,0);
            Peliculas[] lista2 = new Peliculas[15];
            Peliculas peliculas = new Peliculas(null,null,null,null);
            registro registro1 = new registro(null);
            registro registro = new registro(null,null);
            registro[] lista3 = new registro[30];
            string[] listaprueba = new string[10];
            int contador = 0;          
            int resultado = 0;
            int operacion = 0;
            int numero = 1 ;
            int valor = 0;
            int contar = 0;
            int num = 1;
            int sumatoria = 0;
            System.Console.WriteLine(" ");
            System.Console.WriteLine("BIENVENIDOS A NECFLIS");
            while(resultado!=3){
            System.Console.WriteLine("_____________________________");
            System.Console.WriteLine("Selecione una opción");
            System.Console.WriteLine("1. Clientes");
            System.Console.WriteLine("2. Peliculas");
            System.Console.WriteLine("3. Salir");
            System.Console.WriteLine(" ");
            resultado=Convert.ToInt32(Console.ReadLine());
            
                if(resultado==1){
                    while(operacion!=4){
                        System.Console.WriteLine("____________________________");
                        System.Console.WriteLine("          CLIENTES");
                        System.Console.WriteLine("Seleccione un opción");
                        System.Console.WriteLine("1. Ver listado de clientes");
                        System.Console.WriteLine("2. Crear nuevo cliente.");
                        System.Console.WriteLine("3. Selecionar cliente.");
                        System.Console.WriteLine("4. salir");
                        System.Console.WriteLine(" ");

                        operacion=Convert.ToInt32(Console.ReadLine());
                        switch(operacion){
                            case 1: 
                                if (contador ==0)
                                {
                                    System.Console.WriteLine(" ");
                                    System.Console.WriteLine("=============================");
                                    System.Console.WriteLine("No se ha registrado ningun cliente");
                                    System.Console.WriteLine(" ");
                                    System.Console.WriteLine(" ");
                                }  
                                else{
                                System.Console.WriteLine("=============================");
                                System.Console.WriteLine("   Listado de usuarios");
                    
                                for (int i = 0; i < contador; i++)
                                {
                                    usuario = lista[i];
                                    System.Console.WriteLine("["+numero +"]. " + usuario.nombre);
                                    numero++;
                                }
                                numero= 1;
                                System.Console.WriteLine("=============================");
                                }
                            break;
                            case 2:
                                usuario = new Usuario();
                                lista[contador] = usuario;
                                contador++;      
                                System.Console.WriteLine("=============================");
                                System.Console.WriteLine("    Listado de usuarios");
                    
                                for (int i = 0; i < contador; i++)
                                {
                                    usuario = lista[i];
                                    System.Console.WriteLine("["+numero +"]. " + usuario.nombre);
                                    numero++;
                                }
                                numero= 1;
                                System.Console.WriteLine("=============================");             
                            break;

                            case 3:
                                if(contador==0){
                                    System.Console.WriteLine(" ");
                                    System.Console.WriteLine("=============================");
                                    System.Console.WriteLine("No se ha registrado ningun cliente");
                                    System.Console.WriteLine("=============================");
                                    System.Console.WriteLine(" ");
                                }
                                else{
                                System.Console.WriteLine("=============================");
                                System.Console.WriteLine("      Listado de usuarios");
                    
                                for (int i = 0; i < contador; i++)
                                {
                                    usuario = lista[i];
                                    System.Console.WriteLine("["+numero +"]. " + usuario.nombre);
                                    numero++;
                                }
                                numero= 1;
                                System.Console.WriteLine("=============================");
                                System.Console.WriteLine(" ");
                                System.Console.WriteLine("Ingresar el numero del cliente");
                                int valor1 = Int32.Parse(Console.ReadLine());
                                Usuario usuario1 = lista[valor1 -1];
                                System.Console.WriteLine("   Informacion del cliente");
                                System.Console.WriteLine(" ");
                                System.Console.WriteLine("Nombre: "+ usuario1.nombre);
                                System.Console.WriteLine("Direccion: " + usuario1.direccion);
                                System.Console.WriteLine("Edad: " + usuario1.edad);
                                System.Console.WriteLine(" ");

                                while(true){
                                System.Console.WriteLine("=============================");
                                System.Console.WriteLine("Seleccione una opción");
                                System.Console.WriteLine("1. Playlist");
                                System.Console.WriteLine("2. Agregar pelicula");
                                System.Console.WriteLine("3. Atras");
                                System.Console.WriteLine(" ");
                                int indice = Int32.Parse(Console.ReadLine());
                                
                                if (indice ==1){

                                    string nombre =registro1.nombre_usuario;
                                    string nombre2 =usuario1.nombre;
                                    if(nombre == nombre2){
                                        System.Console.WriteLine("===============================");
                                        System.Console.WriteLine("Listado en su playlist");
                                        for (int j = 0; j < registro.contador; j++)
                                            {
                                                string valor2 = registro1.lista[j];
                                                System.Console.WriteLine(num +" " +valor2);
                                                num++;
                                            }
                                            System.Console.WriteLine("===============================");
                                        }
                                    else{
                                        System.Console.WriteLine(" ");
                                        System.Console.WriteLine("===============================");
                                        System.Console.WriteLine("No hay peliculas en su playlist");
                                        System.Console.WriteLine(" ");
                                        System.Console.WriteLine(" ");
                                    }

                                    

                                    num = 1;
                                    
                                    
                                }
                                if (indice ==2){
                                    if(contar ==0){
                                        System.Console.WriteLine(" ");
                                        System.Console.WriteLine("=============================");
                                        System.Console.WriteLine("No se ha registrado ninguna pelicula");
                                        System.Console.WriteLine("=============================");
                                        System.Console.WriteLine(" ");
                                    }
                                    else{
                                    while(true){
                                    System.Console.WriteLine("=============================");
                                    System.Console.WriteLine("     Listado de Peliculas");

                
                                    for (int i = 0; i < contar; i++)
                                    {
                                        peliculas = lista2[i];
                                        System.Console.WriteLine( num +" " + peliculas.nombre);
                                        num++;
                                    }
                                    num = 1;
                                    System.Console.WriteLine("=============================");
    
                                    System.Console.WriteLine("Seleccione la pelicula que desea agregar");
                                    int escojer = Int32.Parse(Console.ReadLine());
                                    if(escojer==0){

                                        registro1 = new registro(usuario1.nombre,listaprueba);
                                        registro.peliculas_usuario = "";
                                        break;
                                        
                                    }
                                    else{
                                       
                                        peliculas = lista2[escojer-1];
                                        string peli = peliculas.nombre;
                                        
                                        
                                         
                                        registro =new registro(peli);
                                        lista3[sumatoria] = registro;
                                        sumatoria++;

                                    }

                                    for (int i = 0; i < sumatoria; i++)
                                    {
                                        registro=lista3[i];
                                        listaprueba[i] = registro.peliculas_usuario;
                                    }



                                    }
                                    }
                                }
                                if (indice ==3){
                                    break;
                                }
                                else{
                                    System.Console.WriteLine("Seleccione una opción");
                                }
                                }
                                }


                            break; 
                            case 4:
                                System.Console.WriteLine("Gracias por usar NecFlis");
                            break;                   
                            default:
                                System.Console.WriteLine("Seleccione una opción");
                            break;
                            }
                    }

                }
                if(resultado ==2){
                //-----------------------------PELICULAS---------------------------------
                    while(valor!=3){
                        System.Console.WriteLine("=============================");
                        System.Console.WriteLine("          PELICULAS");
                        System.Console.WriteLine("Seleccione una opción");
                        System.Console.WriteLine("1. Ver pelicula");
                        System.Console.WriteLine("2. Agregar pelicula");
                        System.Console.WriteLine("3. Salir");
                        System.Console.WriteLine(" ");

                        valor = Int32.Parse(Console.ReadLine());
                        switch(valor){
                            case 1: 
                            if(contar==0){
                                System.Console.WriteLine(" ");
                                System.Console.WriteLine("=============================");
                                System.Console.WriteLine("No se ha registrado ninguna pelicula");
                                System.Console.WriteLine(" ");
                                System.Console.WriteLine(" ");
                            }else{
                            System.Console.WriteLine("=============================");
                            System.Console.WriteLine("    Listado de peliculas");
                                for (int i = 0; i < contar; i++)
                                {
                                    peliculas = lista2[i];
                                    System.Console.WriteLine( num +" " + peliculas.nombre);
                                    num++;
                                }
                                num = 1;
                            }
                            break;

                            case 2:
                                peliculas = new Peliculas();
                                lista2[contar] = peliculas;
                                contar++; 
                                System.Console.WriteLine("=============================");
                                System.Console.WriteLine("    Listado de peliculas");
                                for (int i = 0; i < contar; i++)
                                {
                                    peliculas = lista2[i];
                                    System.Console.WriteLine( num +" " + peliculas.nombre);
                                    num++;
                                }
                                num = 1;
                            
                            break;

                            case 3:
                                System.Console.WriteLine("Gracias por usar NecFlis");
                            break;
                            default:
                                System.Console.WriteLine("Seleccione una opcion");
                            break;
                        }
                    }
                }
                if(resultado == 3){

                    System.Console.WriteLine("Gracias por usar NecFlis");

                }
                else{
                    System.Console.WriteLine("Seleccione uno de los valores");

                }
                }
                
            }
        }
    }

    class Usuario{
        public string nombre;
        public string direccion;
        public int edad;

        public Usuario(string nombre, string direccion, int edad){
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
        }
        public Usuario(){
            System.Console.WriteLine("===============================");
            System.Console.WriteLine("Escriba el nombre del usuario:");
            nombre = Console.ReadLine();
                                            
            System.Console.WriteLine("Escriba la direcion del cliente:");
            direccion = Console.ReadLine();

            System.Console.WriteLine("Escriba la edad del cliente:");
            edad=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("===============================");

        }
    }
    class Peliculas{
        public string nombre;
        public string tipo;
        public string genero;
        public string sinopsis;
        public Peliculas(string nombre, string tipo, string genero, string sinopsis){
            this.nombre = nombre;
            this.tipo = tipo;
            this.genero = genero;
            this.sinopsis = sinopsis;
        }

        public Peliculas(){
            System.Console.WriteLine("Escriba el nombre de la pelicula:");
            nombre = Console.ReadLine();
            System.Console.WriteLine("Seleccione si es serie o película");
            System.Console.WriteLine("1. Serie");
            System.Console.WriteLine("2. Pelicula");
            tipo = Console.ReadLine();
            System.Console.WriteLine("Seleccione el género de la serie o película ");
            System.Console.WriteLine("1. Acción");
            System.Console.WriteLine("2. Romance");
            System.Console.WriteLine("3. Documental");
            System.Console.WriteLine("4. Comedia");
            genero =Console.ReadLine();
            System.Console.WriteLine("Escriba la sinópsis de la serie o pelicula");
            sinopsis = Console.ReadLine();

        }
    }

    class registro{

        public static int contador = 0;
        public string nombre_usuario;

        public string peliculas_usuario;

        public string[] lista;

        
        public registro(string peliculas_usuario){
            
            this.peliculas_usuario =  peliculas_usuario; 
            contador++; 
            
        }

        public registro(string nombre_usuario,string[] lista){
            this.nombre_usuario = nombre_usuario;
            this.lista = lista;
        }
        
    }
