﻿using System;
                //reading all the lines(rows) from the file.
                string[] rows = File.ReadAllLines(filePath);

                //Creating columns
                if (rows.Length > 0)

                //Creating row for each line.(except the first line, which contain column names)
                for (int row = 1; row < rows.Length; row++)