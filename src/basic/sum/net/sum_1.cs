using System;

class SumAlgorithm {
  static void Main() {
    //[1] Input : n명의 국어 점수
    int[] scores = {100, 75, 50, 37, 90, 95};
    int sum = 0;

    //[2] Process
    for(int i = 0; i < scores.Length; i++) {
      if(scores[i] >= 80) {
        sum += scores[i]; //SUM
      }
    }

      //[3] Output
    Console.WriteLine($"{scores.Length}명의 점수 중 80점 이상의 총점 : {sum}");
  }
}

//Statement -> Expression
//(new int[] {100, 75, 50, 37, 90, 95}).Where(s => s >= 80).Sum()
// LINQ : only C# Expression
// Expression == 함수형 프로그래밍 
// ex) y = f(x) + g(x) - 9
// f(x)나 g(x) 함수의 값, 결과값을 가지고 프로그래밍
// Where() Sum() 전부 함수. 결과적으로 값을 가지게 된다.
// (new)는 함수는 아니다.. new 연산자랑 괄호 연산자를 사용해서 데이터 값을 얻은 것
// 원래 연산을 거치면 값이 나온다.
// 간단하게 결과적으로 값을 내놓을 수 있으면 식 Expression. 값을 내놓을 수 없으면 문 Statement
// 식, 단항식, 다항식, *연산식* ... 식은 전부 답을 뽑기 위해 사용
// 함수도 답을 뽑기 위해 사용하는게 진짜 함수
// 값이 나오지 않는 함수 void형 함수는 함수가 아니다. 예전엔 프로시저 Procedure라고 했다.

// https://rextester.com/