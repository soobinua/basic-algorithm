/**
 * n명의 국어 점수 중 80점 이상의 총점 구하기
 */

//[1] Input : n명의 국어 점수
let scores = [100, 75, 50, 37, 90, 95];
let sum = 0;

//[2] Process
sum = summarize(scores.length);

function summarize(index) {
	if (index == 0) {
		return sumScore(0);
	} else {
		return sumScore(index) + summarize(index - 1) //점화식
	}
}

function sumScore(index) {
	if (scores[index] >= 80) {
		return scores[index];
	} else {
		return 0;
	}
}

//[3] Output
console.log(scores.length + "명의 점수 중 80점 이상의 총점은 : " + sum);