namespace Bosscoder.Week_3.Assignment_Questions
{
    public class RectangleArea
    {
        public int GetRectangleArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {
            if (ax1 > bx2 || bx1 > ax2 || ay1 > by2 || by1 > ay2)
                return (ax2 - ax1) * (ay2 - ay1) + (bx2 - bx1) * (by2 - by1);

            int x1 = ax1 > bx1 ? ax1 : bx1;
            int x2 = ax2 < bx2 ? ax2 : bx2;
            int y1 = ay1 > by1 ? ay1 : by1;
            int y2 = ay2 < by2 ? ay2 : by2;

            return ((ax2 - ax1) * (ay2 - ay1)) + ((bx2 - bx1) * (by2 - by1))
                    - ((x2 - x1) * (y2 - y1));
        }
    }
}
