namespace Bosscoder.Week_3.Homework_Questions
{
    public class RectangleOverlap
    {
        public bool DoesRectanglesOverlap(int[] rec1,int[] rec2)
        {
            return !(rec1[2] <= rec2[0] ||
                 rec1[3] <= rec2[1] ||
                 rec1[0] >= rec2[2] ||
                 rec1[1] >= rec2[3]);
        }
    }
}
