using DEMOQATests.Elements;
using OpenQA.Selenium;

namespace DEMOQATests.Helpers;

public class TableUtil
{
    public static int CountNumberOfFilledRows(string rowsXpath, string cellXpath, int indexDifference){
        var amountOfRecords = 0;
        var rows = new Form(By.XPath(rowsXpath), "Rows");
        var rowsElements = rows.GetElements();
        var cellReplaceStr = "cellNumber";
        var cellIndex = 1;

        foreach (var row in rowsElements) {
            var element = row.FindElement(By.XPath(StringUtil.GetXpathWithNumberParam(cellXpath, cellReplaceStr, cellIndex.ToString() )));
            var elementText = element.Text;
            
            if(!elementText.Equals(" ")){
                amountOfRecords++;
            }

            cellIndex += indexDifference;
        }

        return amountOfRecords;
    }
}