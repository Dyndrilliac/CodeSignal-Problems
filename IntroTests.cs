using System;

namespace CodeSignal_Arcade_CSharp
{
    class IntroTests
    {
        private const string PROBLEM_EXIST_ERROR = "Problem does not exist.";

        private const string PROBLEM_IMPLEMENT_ERROR = "Problem not yet implemented.";

        private const string PROBLEM_TESTS_IMPLEMENT_ERROR = "Tests not yet implemented.";

        public class PickProblemException : Exception {
            public PickProblemException(string message) : base(message) {}
        }

        private static char pickAutoTests() {
            Console.WriteLine("\nWould you like automated testing?\n");
            Console.WriteLine("\t[{0}]\t{1}", "Y/y", "Yes, use automated testing.");
            Console.WriteLine("\t[{0}]\t{1}", "N/n", "No, use customized testing.");
            Console.Write("\nSelection (0 to exit):\t");
            return Char.Parse(Console.ReadLine());
        }

        public static uint pickProblem() {
            Console.WriteLine("\nPick a problem:\n");
            Console.WriteLine("\t[{0}]\t{1}", 1, "add");
            Console.WriteLine("\t[{0}]\t{1}", 2, "centuryFromYear");
            Console.WriteLine("\t[{0}]\t{1}", 3, "checkPalindrome");
            Console.WriteLine("\t[{0}]\t{1}", 4, "adjacentElementsProduct");
            Console.WriteLine("\t[{0}]\t{1}", 5, "shapeArea");
            Console.WriteLine("\t[{0}]\t{1}", 6, "makeArrayConsecutive2");
            Console.WriteLine("\t[{0}]\t{1}", 7, "almostIncreasingSequence");
            Console.WriteLine("\t[{0}]\t{1}", 8, "matrixElementsSum");
            Console.WriteLine("\t[{0}]\t{1}", 9, "allLongestStrings");
            Console.WriteLine("\t[{0}]\t{1}", 10, "commonCharacterCount");
            Console.WriteLine("\t[{0}]\t{1}", 11, "isLucky");
            Console.WriteLine("\t[{0}]\t{1}", 12, "sortByHeight");
            Console.WriteLine("\t[{0}]\t{1}", 13, "reverseInParentheses");
            Console.WriteLine("\t[{0}]\t{1}", 14, "alternatingSums");
            Console.WriteLine("\t[{0}]\t{1}", 15, "addBorder");
            Console.WriteLine("\t[{0}]\t{1}", 16, "areSimilar");
            Console.WriteLine("\t[{0}]\t{1}", 17, "arrayChange");
            Console.Write("\nSelection (0 to exit):\t");
            return UInt32.Parse(Console.ReadLine());
        }

        public static void runTests(uint problem) {
            if (problem == 0) return;
            if (problem > 60) throw new PickProblemException(PROBLEM_EXIST_ERROR);
            if (problem > 17) throw new PickProblemException(PROBLEM_IMPLEMENT_ERROR);
            if (testBed(problem)) Console.WriteLine("\nAll tests completed successfully!");
        }

        private static bool testBed(uint problem) {
            bool overallResult = true, autoTests = true, validChoice = false;
            char testChoice = '\0';

            do {
                Console.Clear();
                testChoice = pickAutoTests();

                if (testChoice == '0') {
                    validChoice = true;
                    return false;
                }

                if ((testChoice == 'Y') || (testChoice == 'y')) {
                    autoTests = true;
                    validChoice = true;
                }

                if ((testChoice == 'N') || (testChoice == 'n')) {
                    autoTests = false;
                    validChoice = true;
                }
            } while (!validChoice);

            switch (problem) {
                case 1:
                    overallResult = problem1(autoTests);
                    break;
                case 2:
                    overallResult = problem2(autoTests);
                    break;
                case 3:
                    overallResult = problem3(autoTests);
                    break;
                case 4:
                    overallResult = problem4(autoTests);
                    break;
                case 5:
                    overallResult = problem5(autoTests);
                    break;
                case 6:
                    overallResult = problem6(autoTests);
                    break;
                case 7:
                    overallResult = problem7(autoTests);
                    break;
                case 8:
                    overallResult = problem8(autoTests);
                    break;
                case 9:
                    overallResult = problem9(autoTests);
                    break;
                case 10:
                    overallResult = problem10(autoTests);
                    break;
                case 11:
                    overallResult = problem11(autoTests);
                    break;
                case 12:
                    overallResult = problem12(autoTests);
                    break;
                case 13:
                    overallResult = problem13(autoTests);
                    break;
                case 14:
                    overallResult = problem14(autoTests);
                    break;
                case 15:
                    overallResult = problem15(autoTests);
                    break;
                case 16:
                    overallResult = problem16(autoTests);
                    break;
                case 17:
                    overallResult = problem17(autoTests);
                    break;
            }

            return overallResult;
        }

        private static bool problem1(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                const int numTests = 6;
                const int numArgs = 3;

                int[,] testData = new int[numTests,numArgs]{
                    {1    ,2    ,3    },
                    {0    ,1000 ,1000 },
                    {2    ,-39  ,-37  },
                    {99   ,100  ,199  },
                    {-100 ,100  ,0    },
                    {-1000,-1000,-2000}
                };

                bool[] testResults = new bool[numTests];

                for (int i = 0; i < numTests; i++) {
                    int param1 = testData[i,0], param2 = testData[i,1], answer = testData[i,2];
                    bool success = (IntroSolutions.add(param1, param2) == answer);

                    if (success) testResults[i] = true;
                    else {
                        testResults[i] = false;
                        overallResult = false;
                        Console.WriteLine("\nTest {0} Status:\t\tFailed!", (i + 1));
                        Console.WriteLine("Input Data:\n\tparam1:\t\t{0}\n\tparam2:\t\t{1}", param1, param2);
                        Console.WriteLine("Expected Output:\n\tanswer:\t\t{0}", answer);
                    }
                }
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem2(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem3(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem4(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem5(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem6(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem7(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem8(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem9(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem10(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem11(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem12(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem13(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem14(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem15(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem16(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }

        private static bool problem17(bool autoTests) {
            bool overallResult = true;

            if (autoTests) {
                // TODO: Implement automated testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            } else {
                // TODO: Implement the ability to perform custom testing.
                throw new PickProblemException(PROBLEM_TESTS_IMPLEMENT_ERROR);
            }

            return overallResult;
        }
    }
}