
namespace TestMenuProject.Master {

    @Serenity.Decorators.registerClass()
    export class EmployeeGrid extends Serenity.EntityGrid<EmployeeRow, any> {
        protected getColumnsKey() { return EmployeeColumns.columnsKey; }
        protected getDialogType() { return EmployeeDialog; }
        protected getIdProperty() { return EmployeeRow.idProperty; }
        protected getInsertPermission() { return EmployeeRow.insertPermission; }
        protected getLocalTextPrefix() { return EmployeeRow.localTextPrefix; }
        protected getService() { return EmployeeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getColumns() {
            var columns = super.getColumns();

            columns.splice(1, 0, {
                field: 'Print Employee',
                name: '',
                format: ctx => '<a class="inline-action print-bill" title="Download Employee">' +
                    '<i class="fa fa-file-pdf-o text-red"></i></a>',
                width: 24,
                minWidth: 24,
                maxWidth: 24
            });
            columns.splice(1, 0, {
                field: 'View Employee',
                name: '',
                format: ctx => '<a class="inline-action view-bill" title="View Employee">' +
                    '<i class="fa fa-eye text-blue"></i></a>',
                width: 24,
                minWidth: 24,
                maxWidth: 24
            });
            return columns;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number) {
            super.onClick(e, row, cell);

            if (e.isDefaultPrevented())
                return;

            var item = this.itemAt(row);
            var target = $(e.target);

            // if user clicks "i" element, e.g. icon
            if (target.parent().hasClass('inline-action'))
                target = target.parent();

            if (target.hasClass('inline-action')) {
                e.preventDefault();

                if (target.hasClass('print-bill')) {
                    Serenity.Extensions.ReportHelper.execute({
                        reportKey: 'Employee.EmployeeDetailsReport',
                        params: {
                            EmployeeID: item.EmployeeId
                        }
                    });
                }
                if (target.hasClass('view-bill')) {
                    Serenity.Extensions.ReportHelper.execute({
                        reportKey: 'Employee.EmployeeDetailsReport',
                        extension: 'html',
                        params: {
                            EmployeeID: item.EmployeeId
                        }
                    });
                }
            }
        }

        protected getButtons() {
            var buttons = super.getButtons();

            buttons.push(Serenity.Extensions.ExcelExportHelper.createToolButton({
                grid: this,
                service: EmployeeService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: true
            }));

            buttons.push(Serenity.Extensions.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit()
            }));

            return buttons;
        }
    }
}