using System;

public class Math {
	static int IntAdd (int a, int b) {
		int c = a + b;
		int d = c + b;
		int e = d + a;
		return e;
	}

	public static string Add (string a, string b) {
		return IntAdd (int.Parse(a), int.Parse(b)).ToString ();
	}
}
