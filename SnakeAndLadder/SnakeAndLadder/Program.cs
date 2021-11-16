namespace SnakeAndLadder
{
    class SnakeAndLadder
    
    {
        public int playerPosition = 0;
        Random random = new Random();
        public int DieRolling()
        {
            int roll = random.Next(1, 7);
            return roll;
        }
    }
}