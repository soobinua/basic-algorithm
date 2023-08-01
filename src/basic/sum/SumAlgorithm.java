package basic.sum;

public class SumAlgorithm {

	public static int[] scores = { 100, 75, 50, 37, 90, 95 };

	public static void main(String[] args) {
//		int sum = 0;
//		for (int i = 0; i < scores.length; i++) {
//			if (scores[i] >= 80) {
//				sum += scores[i];
//			}
//		}

		int sum = summarize(scores.length - 1);

		System.out.println(scores.length + "명의 점수 중 80점 이상의 총점은 : " + sum);
	}

	private static int summarize(int index) {
		if (index == 0) {
			return sum(0);
		} else {
			return summarize(index - 1) + sum(index);
		}
	}

	private static int sum(int index) {
		if (scores[index] >= 80) {
			return scores[index];
		}
		return 0;
	}

}
