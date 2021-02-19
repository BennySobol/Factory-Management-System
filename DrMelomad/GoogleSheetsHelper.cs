using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using System.Collections.Generic;

namespace DrMelomad
{
    public class GoogleSheetsHelper
    {
        private readonly SheetsService _sheetsService;
        private readonly string _spreadsheetId;

        public GoogleSheetsHelper()
        {
            // from google's api
            string jsonString = "{\"type\":\"service_account\",\"project_id\":\"shopping-cart........}";
            GoogleCredential credential = GoogleCredential.FromJson(jsonString);

            // if you have a credential file
            //GoogleCredential credential = GoogleCredential.FromStream(new FileStream(credentialFileName, FileMode.Open)).CreateScoped(Scopes);

            _sheetsService = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "GoogleSheetsHelper",
            });

            _spreadsheetId = ".........";
        }

        public void AddCells(GoogleSheetParameters googleSheetParameters, List<GoogleSheetRow> rows)
        {
            var requests = new BatchUpdateSpreadsheetRequest { Requests = new List<Request>() };

            GridCoordinate gc = new GridCoordinate
            {
                ColumnIndex = googleSheetParameters.RangeColumnStart - 1,
                RowIndex = googleSheetParameters.RangeRowStart - 1,
                SheetId = 0
            };

            var UpdateCellsRequest = new Request { UpdateCells = new UpdateCellsRequest { Start = gc, Fields = "*" } };

            var listRowData = new List<RowData>();

            foreach (var row in rows)
            {
                var rowData = new RowData();
                var listCellData = new List<CellData>();
                foreach (var cell in row.Cells)
                {
                    var cellData = new CellData();
                    var extendedValue = new ExtendedValue { StringValue = cell.CellValue };

                    cellData.UserEnteredValue = extendedValue;
                    var cellFormat = new CellFormat { TextFormat = new TextFormat() };

                    cellData.UserEnteredFormat = cellFormat;

                    listCellData.Add(cellData);
                }
                rowData.Values = listCellData;
                listRowData.Add(rowData);
            }
            UpdateCellsRequest.UpdateCells.Rows = listRowData;

            int rowcount = _sheetsService.Spreadsheets.Values.Get(_spreadsheetId, "shopping cart!A:Z").Execute().Values.Count;
            if (rows.Count < rowcount - 1)
            {
                Request DeleteRangeRequest = new Request()
                {
                    DeleteDimension = new DeleteDimensionRequest()
                    {
                        Range = new DimensionRange()
                        {
                            SheetId = 0,
                            Dimension = "ROWS",
                            StartIndex = rows.Count,
                            EndIndex = rowcount - 1
                        }
                    }
                };
                requests.Requests.Add(DeleteRangeRequest);
            } 

            // It's a batch request so you can create more than one request and send them all in one batch. Just use reqs.Requests.Add() to add additional requests for the same spreadsheet
            requests.Requests.Add(UpdateCellsRequest);

            _sheetsService.Spreadsheets.BatchUpdate(requests, _spreadsheetId).Execute();
        }
    }

    public class GoogleSheetCell
    {
        public string CellValue { get; set; }
    }

    public class GoogleSheetParameters
    {
        public int RangeColumnStart { get; set; }
        public int RangeRowStart { get; set; }

        public string SheetName { get; set; }
    }

    public class GoogleSheetRow
    {
        public GoogleSheetRow() { Cells = new List<GoogleSheetCell>(); }

        public List<GoogleSheetCell> Cells { get; set; }
    }
}