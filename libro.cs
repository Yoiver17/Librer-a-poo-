//clase libro
public class libro{
//Atributos
private string titulo="", autor="";
private int ISBN, npage;
/*metodos
consultar titulo*/
public string gettitulo(){
//devuelve un valor cuando se usa
return(this.titulo);
}
//configurar titulo
public string settitulo(string title){
//devuelve un valor cuando se usa
   return this.titulo=title;
}
//consultar autor
public string getautor(){
//devuelve un valor cuando se usa
return(this.autor);
}
//configurar autot
public void setautor(string autor){

this.autor=autor;
}
//consultar ISBN
public int getISBN(){
    //devuelve un valor cuando se usa
return(this.ISBN);
}
//configurar ISBN
public void setISBN(int ncode){
this.ISBN=ncode;
}
//consultar paginas
public int getpage(){
    //devuelve un valor cuando se usa
return(this.npage);
}
//configurar paginas
public void setnpages(int npagi){
this.npage=npagi;
}
//lee unos valores, los convierte y los muestra en pantalla
public void tostring(){ Console.WriteLine("El libro "+this.titulo+" con ISBN "+this.ISBN+" creado por el autor "+this.autor+" tiene "+this.npage+" paginas.");
}
}