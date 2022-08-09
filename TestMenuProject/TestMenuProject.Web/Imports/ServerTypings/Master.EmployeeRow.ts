namespace TestMenuProject.Master {
    export interface EmployeeRow {
        EmployeeId?: number;
        EmployeeName?: string;
        CountryId?: number;
        CountryCountryName?: string;
    }

    export namespace EmployeeRow {
        export const idProperty = 'EmployeeId';
        export const nameProperty = 'EmployeeName';
        export const localTextPrefix = 'Master.Employee';
        export const deletePermission = 'Master:Employee';
        export const insertPermission = 'Master:Employee';
        export const readPermission = 'Master:Employee';
        export const updatePermission = 'Master:Employee';

        export declare const enum Fields {
            EmployeeId = "EmployeeId",
            EmployeeName = "EmployeeName",
            CountryId = "CountryId",
            CountryCountryName = "CountryCountryName"
        }
    }
}
