using System;
using System.Collections.Generic;

namespace DCCodeTest {

    class Score : IScore {
        List<Tuple<int, int>> scoreList = new List<Tuple<int, int>> ();

        public void addScoreForFrame (int scoreFirstFrame, int scoreSecondFrame) {
            scoreList.Add (Tuple.Create (scoreFirstFrame, scoreSecondFrame));
        }

        public int getCurrentScore () {
            int res = 0;

            for (int i = 0; i < scoreList.Count; i++) {
                if (isStrike (i) && i == scoreList.Count - 1) {
                    res += 0;
                } else if (isStrike (i)) {
                    res += getStrikeScore (i + 1);
                } else if (isSpare (i) && i == scoreList.Count - 1) {
                    res += 0;
                } else if (isSpare (i)) {
                    res += getSpareScore (i + 1);
                } else {
                    res += getframeScore (i);
                }
            }
            return res;
        }

        private int getStrikeScore (int index) {
            int first = scoreList[index].Item1;
            int second = scoreList[index].Item2;

            if (first == 10 && index == scoreList.Count - 1) {
                return 0;
            } else if (first == 10) {
                return 20 + scoreList[index + 1].Item1;
            }
            return 10 + first + second;
        }

        private int getSpareScore (int index) {
            int first = scoreList[index].Item1;

            return 10 + first;
        }

        private int getframeScore (int index) {
            int first = scoreList[index].Item1;
            int second = scoreList[index].Item2;

            return first + second;
        }

        private Boolean isStrike (int index) {
            int first = scoreList[index].Item1;

            if (first == 10) {
                return true;
            }
            return false;
        }

        private Boolean isSpare (int index) {
            int first = scoreList[index].Item1;
            int second = scoreList[index].Item2;

            if (first + second == 10 && first != 10) {
                return true;
            }
            return false;
        }
    }
}