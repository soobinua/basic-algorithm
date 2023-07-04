using System;

class SumAlgorithm {
  static void Main() {
    //[1] Input : n명의 국어 점수
    int[] scores = {100, 75, 50, 37, 90, 95};
    int sum = 0;

    //[2] Process
    sum += summarize(scores.Length - 1);

    int summarize(int index) {
      if(index == 0) {
        return funcSum(scores[0]);
      }
      return funcSum(scores[index]) + summarize(index - 1);
    }
    
    int funcSum(int score) {
      int ret = 0;
      if(score >= 80) {
        ret = score;
      }
      return ret;
    }

    //[3] Output
    Console.WriteLine($"{scores.Length}명의 점수 중 80점 이상의 총점 : {sum}");
  }
}

// 시그마(6) = 6 + 시그마(5)
//           = 6 + 5 + 시그마(4)
//           = 6 + 5 + 4 + 시그마(3)

// Sum(5)
// = (1 + 2 + 3 + 4 + 5)
// = (5 + 4 + 3 + 2 + 1)
// = 5 + (4 + 3 + 2 + 1)
// = 5 + 4 + (3 + 2 + 1)
// = 5 + 4 + 3 + (2 + 1)
// = 5 + 4 + 3 + 2 + (1)
// = 5 + 4 + 3 + 2 + Sum(1)
// = 5 + 4 + 3 + Sum(2)
// = 5 + 4 + Sum(3)
// = 5 + Sum(4)
// = Sum(5)