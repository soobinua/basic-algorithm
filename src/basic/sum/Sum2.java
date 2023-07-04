package basic.sum;

/**
 * n명의 국어 점수 중 80점 이상의 총점 구하기
 */
public class Sum2 {

	public static int[] scores = { 100, 75, 50, 37, 90, 95 };

	private static int summarize(int index) {
		if (index == 0) {
			return sum(0);
		}
		return sum(index) + summarize(index - 1);
	}

	private static int sum(int index) {
		if (scores[index] >= 80) {
			return scores[index];
		}
		return 0;
	}

	public static void main(String[] args) {

		int sum = summarize(scores.length - 1);

		System.out.println(scores.length + "명의 점수 중 80점 이상의 총점은 : " + sum);
	}

}
