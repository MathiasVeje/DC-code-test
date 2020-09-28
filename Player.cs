namespace DCCodeTest {

    class Player : IPlayer {
        private IScore score = new Score ();
        private string name;

        public Player (string name) {
            this.name = name;
        }

        public string getName () => name;

        public int getScore () {
            return score.getCurrentScore ();
        }

        public void setScoreForframe (int firstRoll, int secondRoll) {
            score.addScoreForFrame (firstRoll, secondRoll);
        }

    }
}