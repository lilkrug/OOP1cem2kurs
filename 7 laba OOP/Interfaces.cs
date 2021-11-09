namespace _7_laba_OOP
{
    public interface IGeneric<T>
    {
        /*1.Создайте обобщенный интерфейсс  операциями  добавить, удалить,просмотреть.*/

        void Add(T item);
        void Delete(T item);
        void Show();
    }

}