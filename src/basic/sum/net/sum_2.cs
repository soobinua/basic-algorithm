using System;

class SumAlgorithm {
  static void Main() {
    //[1] Input : n명의 국어 점수
    int[] scores = {100, 75, 50, 37, 90, 95};
    int sum = 0;

    //[2] Process
    int score = scores[0];
    if(score >= 80) {
      sum += score; //SUM
    }

    score = scores[1];
    if(score >= 80) {
      sum += score; //SUM
    }

    score = scores[2];
    if(score >= 80) {
      sum += score; //SUM
    }

    score = scores[3];
    if(score >= 80) {
      sum += score; //SUM
    }

    score = scores[4];
    if(score >= 80) {
      sum += score; //SUM
    }
    
    score = scores[5];
    if(score >= 80) {
      sum += score; //SUM
    }

    //[3] Output
    Console.WriteLine($"{scores.Length}명의 점수 중 80점 이상의 총점 : {sum}");
  }
}