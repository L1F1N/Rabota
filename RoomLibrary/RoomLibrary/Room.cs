using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLengt;
        double roomWidth;
        public double roomLength
        {
            get { return roomLengt; }
            set { roomLengt = value; }
        }
        public double RoomWidth
        { get { return roomWidth; } set { roomWidth = value; } }

        /// <summary>
        /// Метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>Возвращает значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLength + roomWidth);
        }

        /// <summary>
        /// Метод вычисляет площадь комнаты
        /// </summary>
        /// <returns>Возвращает значение площади</returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }
        /// <summary>
        /// Метод вычисляет число квадратных метров
        /// на одного человека
        /// </summary>
        /// <param name="np">Число человек</param>
        /// <returns>Возвращает число квадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }

        public virtual string Info()
        {
            return "Комната с площадью " + RoomArea() + "кв.м";
        }
    }

    public class LivingRoom : Room
    {
        int numWin;
        public int NumWin
        { get { return numWin; } set { numWin = value; } }

        public override string Info()
        {
            return "Жилая комната площадью " + RoomArea() + " кв.мб с " + numWin + " окнам";
        }
    }

    public class Office : Room
    {
        int numSockets;
        public int NumSockets
        { get { return numSockets; } set { numSockets = value; } }

        /// <summary>
        /// Возвращает максимально возможне число рабочих мест
        /// </summary>
        /// <returns>Возвращает число мест</returns>
        public int NumWorkplaces()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(numSockets, num);
        }
        public override string Info()
        {
            return "Офис на " + NumWorkplaces() + " рабочих мест";
        }
    }

}
