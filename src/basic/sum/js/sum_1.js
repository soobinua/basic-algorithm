/**
 * n명의 국어 점수 중 80점 이상의 총점 구하기
 */

//[1] Input : n명의 국어 점수
let scores = [100, 75, 50, 37, 90, 95];
let sum = 0;

//[2] Process
for (let i = 0; i < scores.length; i++) {
	if (scores[i] >= 80) {
		sum += scores[i];
	}
}

//[3] Output
console.log(scores.length + "명의 점수 중 80점 이상의 총점은 : " + sum);

// RUN
// eclipse - JAVA >  Ctrl + F11
// vscode - Code Runner > Ctrl + Alt + N