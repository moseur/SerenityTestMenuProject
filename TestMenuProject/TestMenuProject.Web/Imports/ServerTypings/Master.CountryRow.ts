namespace TestMenuProject.Master {
    export interface CountryRow {
        CountryId?: number;
        CountryName?: string;
    }

    export namespace CountryRow {
        export const idProperty = 'CountryId';
        export const nameProperty = 'CountryName';
        export const localTextPrefix = 'Master.Country';
        export const lookupKey = 'Master.Country';

        export function getLookup(): Q.Lookup<CountryRow> {
            return Q.getLookup<CountryRow>('Master.Country');
        }
        export const deletePermission = 'Master:Country';
        export const insertPermission = 'Master:Country';
        export const readPermission = 'Master:Country';
        export const updatePermission = 'Master:Country';

        export declare const enum Fields {
            CountryId = "CountryId",
            CountryName = "CountryName"
        }
    }
}
