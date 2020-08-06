import { Expenditures } from './expenditures';
import { Incomes } from './incomes';

export interface Users {
    id: number;
    email: string;
    password: string;
    fullName: string;
    incomes: Incomes[],
    expenditures: Expenditures[]
    joinedOn?: Date;
}