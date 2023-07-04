package basic.sum;

/**
 * n명의 국어 점수 중 80점 이상의 총점 구하기
 */
public class Sum1 {

	public static int[] scores = { 100, 75, 50, 37, 90, 95 };

	public static void main(String[] args) {
		int sum = 0;

		for (int score : scores) {
			if (score >= 80) {
				sum += score;
			}
		}
		System.out.println(scores.length + "명의 점수 중 80점 이상의 총점은 : " + sum);
	}
}
