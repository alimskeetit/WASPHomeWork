using MusicStore;

class Program
{
    public static void Main()
    {
        Store store = new Store("Muza", "Проспект Вернадского, 78");

        //диск металлики
        var metallica = new Audio("Metallica", "Blackened Studio", 10, "Metallica", "Metal");
        
        //добавили в магазин
        store = store + metallica;

        //добавили в магазин Нирвану
        store = store + new Audio("Nirvana", "Apple", 10, "Nevermind", "Grunge");

        //диск америкаский психопат
        var psycho = new DVD("Christian Bale", "Sony", 190, "American Psycho", "Slasher");
        
        //добавили в магазин
        store = store + psycho;
        //добавили Маску в магазин
        store = store + new DVD("James Cameron", "Metrogoldwyn Mayer", 220, "Mask", "Comedy");

        //вывели содержимое магазина
        Console.WriteLine(store.ToString());

        //прожгли металлику
        metallica.Burn("Черный альбом", "Рок","Кино", "Айзеншпис", "9");
        Console.WriteLine(metallica.ToString());
        Console.WriteLine();

        Console.WriteLine(store.ToString());

        //удалили диск 
        store = store - metallica;

        Console.WriteLine(store.ToString());

    }
}