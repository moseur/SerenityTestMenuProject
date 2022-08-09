namespace TestMenuProject.Master {
    export interface EmployeeForm {
        EmployeeName: Serenity.StringEditor;
        CountryId: Serenity.LookupEditor;
    }

    export class EmployeeForm extends Serenity.PrefixedContext {
        static formKey = 'Master.Employee';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!EmployeeForm.init)  {
                EmployeeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(EmployeeForm, [
                    'EmployeeName', w0,
                    'CountryId', w1
                ]);
            }
        }
    }
}
