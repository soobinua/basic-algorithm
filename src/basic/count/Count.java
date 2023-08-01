package basic.count;

public class Count {
	/**
	 * 개수 알고리즘(Count Algorithm) : 주어진 범위에 주어진 조건에 해당하는 자료들의 개수
	 */

	public static void main(String[] args) {
		// [?] 1부터 1000까지의 정수 중 13의 배수의 개수

		// [1] Input : 1부터 1,000까지의 데이터
		int count = 0;

		// [2] Process : 개수 알고리즘 영역 : 주어진 범위에 주어진 조건(필터링)
		for (int i = 1; i <= 1000; i++) {
			if (i % 13 == 0) {
				count++;
			}
		}

		// [3] Output
		System.out.println("1부터 1000까지의 정수 중 13의 배수의 개수 : " + count);
	}

}
