using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON
{
    class Functions
    {
        //CroatiaAlphabet star = new CroatiaAlphabet();

        //string str = Console.ReadLine();
        //star.Function(str);


        //GroupMeanChecker checker = new GroupMeanChecker();

        //int count = Convert.ToInt32(Console.ReadLine());

        //string[] strs = new string[count];
        //for (int i = 0; i < strs.Length; ++i)
        //{
        //    strs[i] = Console.ReadLine();
        //}

        //checker.Function(strs);

        ///////////////////////////////////////
        //YourGrade yourGrade = new YourGrade();

        ////int count = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i < 20; ++i)
        //{
        //    string read = Console.ReadLine();
        //    var strs = read.Split(" ");

        //    if (strs.Length > 3)
        //        continue;

        //    Grade grade = new Grade(strs[0], (float)Convert.ToDouble(strs[1]), strs[2]);
        //    yourGrade.AddGrades(grade);
        //}

        //yourGrade.Function();

        //////////////////////////////////////////
        //ProcessionSum processSum = new ProcessionSum();

        //string[] readStr = Console.ReadLine().Split(" ");

        //int col = Convert.ToInt32(readStr[0]);
        //int row = Convert.ToInt32(readStr[0]);

        //string[] strs = new string[col * 2];

        //for(int i = 0; i < col * 2; ++i)
        //{
        //    strs[i] = Console.ReadLine();
        //}

        //processSum.Function(row, col, strs);


        //int[,] values = new int[9, 9];
        //for(int i = 0; i < 9; ++i)
        //{
        //    string[] str = Console.ReadLine().Split(" ");

        //    for(int j = 0; j < str.Length; ++j)
        //    {
        //        values[i, j] = Convert.ToInt32(str[j]);
        //    }

        //}

        //MaxValueFind finds = new MaxValueFind();
        //finds.Function(values);

        ///////////////////////////////////////
        //HeightRead height = new HeightRead();

        //string[] readLines = new string[5];
        //for(int i = 0; i < 5; ++i)
        //{
        //    readLines[i] = Console.ReadLine();

        //}

        //height.Function(readLines);

        ///////////////////////////////////////
        //ColoredPaper coloredPaper = new ColoredPaper();

        //int count = Convert.ToInt32(Console.ReadLine());

        //int[,] _pos = new int[count, 2];
        //for(int i = 0; i < count; ++i)
        //{
        //    string[] readLine = Console.ReadLine().Split(' ');
        //    for(int j = 0; j < readLine.Length; ++j)
        //    {
        //        _pos[i, j] = Convert.ToInt32(readLine[j]);
        //    }
        //}

        //coloredPaper.Function(_pos);

        ////////////////////////////////////////
        //FormationConvert formationConvert = new FormationConvert();

        //string[] readStrs = Console.ReadLine().Split(' ');

        //if(readStrs.Length == 2)
        //    formationConvert.Function(readStrs[0], int.Parse(readStrs[1]));

        /////////////////////////////////////////
        //CenterMove centerMove = new CenterMove();
        //int count = int.Parse(Console.ReadLine());

        //centerMove.Function(count);


        /////////////////////////////////////////
        //HoneyComb honeyComb = new HoneyComb();
        //int count = int.Parse(Console.ReadLine());

        //honeyComb.Function(count);

        ///////////////////////////////////////////////
        //FountainFind find = new FountainFind();

        //find.Function(int.Parse(Console.ReadLine()));

        ///////////////////////////////////////////////
        //TreeClimb climb = new TreeClimb();
        //string[] readLine = Console.ReadLine().Split(' ');
        //climb.Function(int.Parse(readLine[0]), int.Parse(readLine[1]), int.Parse(readLine[2]));

        ///////////////////////////////////////////////
        //CommonMultipleFind find = new CommonMultipleFind();


        //Queue<int> queue_A = new Queue<int>();
        //Queue<int> queue_B = new Queue<int>();
        //while(true)
        //{
        //    string[] readLine = Console.ReadLine().Split(' ');

        //    int _a = int.Parse(readLine[0]);
        //    int _b = int.Parse(readLine[1]);

        //    if (_a == 0 && _b == 0)
        //        break;

        //    queue_A.Enqueue(_a);
        //    queue_B.Enqueue(_b);
        //}


        //find.Function(queue_A, queue_B);

        //////////////////////////////////////////////////
        //CommonNumFind find = new CommonNumFind();

        //string[] readLine = Console.ReadLine().Split(' ');
        //find.Function(int.Parse(readLine[0]), int.Parse(readLine[1]));
        ///////////////////////////////////////////////////
        //CommonNumSum find = new CommonNumSum();
        //Queue<int> queue_A = new Queue<int>();
        //while (true)
        //{
        //    string readLine = Console.ReadLine();

        //    int _a = int.Parse(readLine);

        //    if (_a == -1)
        //        break;

        //    queue_A.Enqueue(_a);
        //}

        //find.Function(queue_A);

        /////////////////////////////////////////////
        //DecimalFind find = new DecimalFind();

        //int count = int.Parse(Console.ReadLine());

        //string[] read = Console.ReadLine().Split(' ');
        //int[] reads = new int[count];
        //for(int i = 0; i < read.Length; ++i)
        //{
        //    reads[i] = int.Parse(read[i]);
        //}

        //find.Function(reads);
        ////////////////////////////////////////////////
        //DecimalFind_2 find = new DecimalFind_2();
        //int min = int.Parse(Console.ReadLine());
        //int max = int.Parse(Console.ReadLine());

        //find.Function(min, max);
        ////////////////////////////////////////////////
        //Factorization factorization = new Factorization();
        //int read = int.Parse(Console.ReadLine());

        //factorization.Function(read);

        ////////////////////////////////////////////////
        //Rectangle rectangle = new Rectangle();

        //int witdh = int.Parse(Console.ReadLine());
        //int height = int.Parse(Console.ReadLine());

        //rectangle.Function(witdh, height);

        ////////////////////////////////////////////////
        //string[] readStr = Console.ReadLine().Split(' ');
        //int x = int.Parse(readStr[0]);
        //int y = int.Parse(readStr[1]);
        //int w = int.Parse(readStr[2]);
        //int h = int.Parse(readStr[3]);

        //RectangleEscape escape = new RectangleEscape();
        //escape.Function(x, y, w, h);

        ////////////////////////////////////////////////
        //RectangleVertexFind find = new RectangleVertexFind();

        //int[] a = new int[2];
        //int[] b = new int[2];
        //int[] c = new int[2];

        //string[] readStrA = Console.ReadLine().Split(' ');
        //string[] readStrB = Console.ReadLine().Split(' ');
        //string[] readStrC = Console.ReadLine().Split(' ');

        //for(int i = 0; i < a.Length; ++i)
        //{
        //    a[i] = int.Parse(readStrA[i]);
        //    b[i] = int.Parse(readStrB[i]);
        //    c[i] = int.Parse(readStrC[i]);
        //}

        //find.Function(a, b, c);

        ////////////////////////////////////////////////
        //RectangleLength length = new RectangleLength();
        //length.Function(uint.Parse(Console.ReadLine()));

        ////////////////////////////////////////////////
        //int pointCount = int.Parse(Console.ReadLine());

        //Queue<int[]> queue = new Queue<int[]>();
        //for(int i =0; i < pointCount; ++i)
        //{
        //    string[] readStrs = Console.ReadLine().Split(' ');

        //    int[] points = new int[2];
        //    points[0] = int.Parse(readStrs[0]);
        //    points[1] = int.Parse(readStrs[1]);

        //    queue.Enqueue(points);
        //}

        //RectangleGroundFind find = new RectangleGroundFind();

        //find.Function(queue);

        ////////////////////////////////////////////////
        //Triangle triangle = new Triangle();

        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int c = int.Parse(Console.ReadLine());

        //triangle.Function(a, b, c);
        ////////////////////////////////////////////////

    }
}
