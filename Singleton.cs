using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1
{
    internal class Singleton
    {
        private static Singleton instance;
        public string type { get; private set; }
        public string size { get; private set; }
        private Singleton(string _type, string _size)
        {
            type = _type;
            size = _size;
        }
        public static Singleton GetInstance(string _type, string _size)
        {
            if (instance == null)
                instance = new Singleton(_type, _size);
            return instance;
        }
    }
    class Order
    {
        public Singleton singleton { get; set; }
        public void Launch(string type, string size)
        {
            singleton = Singleton.GetInstance(type, size);
        }
        public void OrderStatus(Order order)
        {
            DialogResult dialogResult = MessageBox.Show($"Ваш заказ {order.singleton.type} размера {order.singleton.size}. Верно?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Random rand = new Random();
                int r = rand.Next(1, 5);
                if (r == 1)
                {
                    MessageBox.Show("Мы приступили к выполнению вашего заказа", "Ожидайте", MessageBoxButtons.OK);
                    MessageBox.Show("Ваш заказ готов. Вы можете его забрать.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (r == 2)
                {
                    MessageBox.Show("Извините, мыши сгрызли все нитки...", "", MessageBoxButtons.OK);
                }
                if (r == 3)
                {
                    MessageBox.Show("Случилось перенапряжение сети и швейные машины перестали работать", "Неполадочки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (r == 4)
                {
                    MessageBox.Show("Король запретил носить одежду и мы не можем выполнить ваш заказ", "Указ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
