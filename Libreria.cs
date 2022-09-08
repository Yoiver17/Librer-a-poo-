//clase principal
  public class Libreria{
    //metodo principal
   public static void Main(String[] args){
    //defino una istancia de libreria como lascivia y inicializo como nueva
    libro lascivia=new libro();
    //configurar titulo
    lascivia.settitulo("Lascivia");
     //configurar autor 
    lascivia.setautor("Eva Muñoz");
    //configurar páginas 
    lascivia.setnpages(428);
    //configurar ISBN
    lascivia.setISBN(637710);
    //defino una istancia de libreria como akelarre y la inacializo como nueva
    libro akelarre=new libro();
    //configurar titulo
    akelarre.settitulo("Akelarre");
    //confiurar autor 
    akelarre.setautor("Mario Mendoza");
    //configurar páginas 
    akelarre.setnpages(400);
    //configurar ISBN 
    akelarre.setISBN(622834);
    //lee unos valores, los convierte y los muestra en pantalla
    lascivia.tostring();
    //lee unos valores, los convierte y los muestra en pantalla
    akelarre.tostring();

        //condicional sí
        if(lascivia.getpage()>akelarre.getpage()){
            //muestra en pantalla que el primer libro tiene más páginas
            Console.WriteLine("El primer libro tiene más páginas");
            //condicional siNo
        }else{
            //muestra en pantalla que el segundo libro tiene más páginas
            Console.WriteLine("El segundo libro tiene más páginas");
        }



    }
}
  