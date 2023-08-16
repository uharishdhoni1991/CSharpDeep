Algorithm X is an algorithm for solving the exact cover problem. It is a straightforward recursive, nondeterministic, depth-first,
backtracking algorithm used by Donald Knuth to demonstrate an efficient implementation called DLX, which uses the dancing links technique.

Example:

 /**
     * Rearranges an array of objects in uniformly random order
     * (under the assumption that {@code Math.random()} generates independent
     * and uniformly distributed numbers between 0 and 1).
     * @param a the array to be shuffled
     */
        public static void shuffle(Object[] a) {
        int n = a.length;
        for (int i = 0; i < n; i++) {
                // choose index uniformly in [0, i]
                int r = (int) (Math.random() * (i + 1));
                Object swap = a[r];
                a[r] = a[i];
                a[i] = swap;
            }
        }
