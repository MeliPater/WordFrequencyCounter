# Word Frequency Counter Algorithm

Algorithm that reads a text file and counts the frequency of words in the given text, it counts words and characters, and also displaying thewords and the frequency.

### Example

Given a file with the text below:

> lumu lumu lumu lumu lumu illuminates illuminates attacks and adversaries
> 
> lumu illuminates all attacks and adversaries

The algorithm should print the following output:

| 16 | words|
|:----|------|
| 116 | characters |


|lumu: | 6 |
|:------|---|
|illuminates: | 3 |
|attacks: | 2 |
|adversaries: | 2 |
|and: | 2 |
|all: | 1 |

### Computational complexity of the algorithm

Due to the nature of the functions implemented within the algorithm for the identification of characters and words (regular expressions and foreach) that are repeated periodically within the same execution of the algorithm, the complexity inherent in this algorithm grows exponentially as it increases the length and complexity of the examined text. This limitation reduces the scope of the algorithm to the extent that it is functionally practical for light tasks but inefficient in the face of extensive text, evidenced in resource consumption and long execution times.

## Resources
- Visual Studio
- Test files .txt
- C#

## Tutorial

1. Download the .zip of the project.
2. Unzip the project and go to the path: *WordFrequencyCounter-main > bin > Publicar*
3. Open the file named "WordFreqCounter.exe"
4. Load the .txt file you want to test (in the path *WordFrequencyCounter-main > Archivo de Prueba* you will find two sample files)

<p align="center"><img src="http://g.recordit.co/RzA0fwLz2q.gif" width=60% height=60%> </p>
