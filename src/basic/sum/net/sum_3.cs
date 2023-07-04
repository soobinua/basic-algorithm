using System;

class SumAlgorithm {
  static void Main() {
    //[1] Input : n명의 국어 점수
    int[] scores = {100, 75, 50, 37, 90, 95};
    int sum = 0;

    //[2] Process
    int score = scores[0];
    funcSum(score);

    score = scores[1];
    funcSum(score);

    score = scores[2];
    funcSum(score);

    score = scores[3];
    funcSum(score);

    score = scores[4];
    funcSum(score);
    
    score = scores[5];
    funcSum(score);
    
    int funcSum(int score) {
      if(score >= 80) {
        sum += score;
      }
      return sum;
    }

    //[3] Output
    Console.WriteLine($"{scores.Length}명의 점수 중 80점 이상의 총점 : {sum}");
  }
}