using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        public string titulo;
        public Int16 año;
       // public string pais;
       // public string director;
        private List<Actor> actores = new List<Actor>();

        //Constructores
         //Métodos
  /*  public Pelicula (string titulo, Int16 año, string pais, string director){
        this.titulo = titulo;
        this.año = año;
        this.pais = pais;
        this.director = director;
}*/
        public Int16 GetAño(){
            return año;
            }
          public string GetTitulo(){
            return titulo;
            }
        public void SetAño(Int16 año){
            this.año = año;
            }

        public void SetTitulo(string Titulo){
            this.Titulo = Titulo;}
        public string Titulo { 
            get {return titulo;}
            set {titulo = value;}
            }
         public Int16 Año { 
            get {return año;}
            set {año = value;}
            }  
         public Pelicula(string Titulo, Int16 Año) {
            this.Titulo = Titulo;
            this.Año = Año;
            }
        public Pelicula() {

            }
        public void Imprime() {
          Console.WriteLine($"{titulo} ({año})");
            }
            public void ImprimeActores(){

            foreach (Actor a in actores)
             {
               Console.WriteLine(a);
            }
                }
            public void AgregaActor(Actor actor) {
            actores.Add(actor);
            }
        }
        

       


    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas
    
    public class Actor
    {
        //Propiedades
        private string NombreA;
        private Int16 AñoA; 

        //Constructores
        public Actor(string NombreA, Int16 AñoA) {
            this.NombreA = NombreA;
            this.AñoA = AñoA;
        }

        //Métodos 
        public override string ToString(){
            return $"{NombreA} ({AñoA})";
        }  
        public Int16 GetAñoActor(){
            return AñoA;
            }
        public string GetNombre(){
            return NombreA;
            }
        public void SetAñoActor(Int16 añoA){
            this.AñoA = añoA;
            }
     
        public void SetNombre(string NombreA){
            this.NombreA = NombreA;
            }
        public string nombreA { 
            get {return NombreA;}
            set {NombreA = value;}
        }
        public Int16 añoA { 
            get {return AñoA;}
            set {AñoA = value;}
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas
    
    class Program
    {
        static void Main(string[] args)
        { 

        
        Pelicula p1 = new Pelicula("La La Land", 2016);
        p1.AgregaActor(new Actor("Ryan Gosling", 1980));
        p1.AgregaActor(new Actor("Emma Stone", 1988));
        p1.ImprimeActores();
            /*
        List<Pelicula> peliculas = new List<Pelicula>();
        
        peliculas.Add(new Pelicula() { Titulo = "La La Land", año = 2016 });
        peliculas.Add(new Pelicula() { Titulo = "Green Book", año = 2019 });
        peliculas.Add(new Pelicula() { Titulo = "Parasite", año = 2019 });
        peliculas.Add(new Pelicula() { Titulo = "Pinocho", año = 2022 });
        peliculas.Add(new Pelicula() { Titulo = "CODA", año = 2021 });
        foreach (Pelicula p in peliculas)
        {
            Console.WriteLine($"{p.Titulo} ({p.año})");
        } 
           
           Pelicula p1 = new Pelicula();
           p1.SetTitulo("La La Land");
           p1.SetAño(2016);
           Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
           
           Pelicula p1 = new Pelicula("Parasitos","Corea del Sur",2019,"Bong Joon-ho");
           p1.Imprime();
           Pelicula p2 = new Pelicula("Green Book","EUA",2019,"Peter Farrelly");
           p2.Imprime(); */
        }
    }
}