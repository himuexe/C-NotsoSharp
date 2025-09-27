public class BinaryStrings {
    public static void PrintBinaryStrings(int n, int lastPlace, String str) {
        if (n == 0) {
            Console.WriteLine(str);
            return;
        }

        // Always append 0
        PrintBinaryStrings(n - 1, 0, str + "0");

        // Append 1 only if last was 0
        if (lastPlace == 0) {
            PrintBinaryStrings(n - 1, 1, str + "1");
        }
    }

    public static void Main(string[] args) {
        PrintBinaryStrings(3, 0, "");
    }
}